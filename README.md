# NameListIndexer

ICE Task 1 — Advanced C# Features. A console application demonstrating a custom **indexer** on a `NameList` class.

## About

The `NameList` class stores names in a private `List<string>` and exposes an indexer so names can be read and written with array-style syntax:

- **Get** — returns the name at the specified index, or `null` if the index is out of range.
- **Set** — updates the name at an existing index, or appends a new name when the index equals the current count.

## Sample Output

```
Names in the list:
Index 0: Matthew
Index 1: Jane
Index 2: Pete

Updated names in the list:
Index 0: Matthew
Index 1: Jane
Index 2: Pete
Index 3: Reagan

Retrieving name at index 5:
Name not found
```

## Run

```bash
dotnet run
```
