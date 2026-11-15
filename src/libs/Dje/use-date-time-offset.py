#!/usr/bin/env python3
"""Type the date-time query parameters as DateTimeOffset and send them with their offset."""

from __future__ import annotations

import re
import sys
from pathlib import Path

# AutoSDK types a date-time query parameter as DateTime and writes it with a literal "Z", which drops the offset.
UTC_FORMAT = re.compile(r'(\w+)(\??)\.ToString\("yyyy-MM-ddTHH:mm:ssZ"\)')
OFFSET_FORMAT = r'\1\2.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFFzzz", global::System.Globalization.CultureInfo.InvariantCulture)'


def interface_of(client_file: Path) -> Path:
    return client_file.with_name(re.sub(r"\.Sdk\.(\w+Client)\.", r".Sdk.I\1.", client_file.name, count=1))


def retype(path: Path, names: set[str]) -> None:
    text = path.read_text(encoding="utf-8")
    for name in names:
        text = re.sub(rf"global::System\.DateTime(\??) {name}\b", rf"global::System.DateTimeOffset\1 {name}", text)
    path.write_text(UTC_FORMAT.sub(OFFSET_FORMAT, text), encoding="utf-8")


def main() -> None:
    retyped = 0
    for client_file in sorted(Path(sys.argv[1]).glob("*Client.*.g.cs")):
        names = {match.group(1) for match in UTC_FORMAT.finditer(client_file.read_text(encoding="utf-8"))}
        if not names:
            continue
        retype(client_file, names)
        if (interface := interface_of(client_file)).exists():
            retype(interface, names)
        retyped += len(names)
    if retyped == 0:
        sys.exit("No date-time query parameter found; AutoSDK changed how it writes them.")


if __name__ == "__main__":
    main()
