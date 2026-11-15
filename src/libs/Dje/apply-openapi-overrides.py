#!/usr/bin/env python3
"""Make the DJE OpenAPI document byte-stable so regeneration is deterministic."""

from __future__ import annotations

import json
import sys
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


def main() -> None:
    path = Path(sys.argv[1])
    document = json.loads(path.read_text(encoding="utf-8"))
    path.write_text(json.dumps(normalize(document), ensure_ascii=False, indent=2) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()
