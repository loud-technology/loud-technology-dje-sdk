#!/usr/bin/env python3
"""Make the DJE OpenAPI document byte-stable so regeneration is deterministic."""

from __future__ import annotations

import json
import sys
import unicodedata
from pathlib import Path
from typing import Any


def normalize(node: Any) -> Any:
    if isinstance(node, list):
        return [normalize(item) for item in node]
    if not isinstance(node, dict):
        return node
    return {
        key: normalize_properties(value) if key == "properties" and isinstance(value, dict) else normalize(value)
        for key, value in node.items()
    }


def normalize_properties(properties: dict[str, Any]) -> dict[str, Any]:
    # The gateway returns some schema properties in a different order on each request.
    return {name: normalize(schema) for name, schema in sorted(properties.items())}


def strip_accents(text: str) -> str:
    return "".join(c for c in unicodedata.normalize("NFKD", text) if not unicodedata.combining(c))


def ascii_tags(document: dict[str, Any]) -> None:
    # Tags name the sub-clients, so "Comunicação" would become client.Comunicação.
    for tag in document.get("tags", []):
        tag["name"] = strip_accents(tag["name"])
    for path_item in document.get("paths", {}).values():
        for operation in path_item.values():
            if isinstance(operation, dict) and "tags" in operation:
                operation["tags"] = [strip_accents(tag) for tag in operation["tags"]]


def date_time_query_as_string(document: dict[str, Any]) -> None:
    # AutoSDK formats a date-time query parameter as DateTime with a literal "Z" and drops the offset.
    # As a string, the caller sends the exact ISO 8601 value, offset included.
    for path_item in document.get("paths", {}).values():
        for operation in path_item.values():
            if not isinstance(operation, dict):
                continue
            for parameter in operation.get("parameters", []):
                schema = parameter.get("schema", {})
                if parameter.get("in") == "query" and schema.get("format") == "date-time":
                    del schema["format"]


def main() -> None:
    path = Path(sys.argv[1])
    document = json.loads(path.read_text(encoding="utf-8"))
    ascii_tags(document)
    date_time_query_as_string(document)
    path.write_text(json.dumps(normalize(document), ensure_ascii=False, indent=2) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()
