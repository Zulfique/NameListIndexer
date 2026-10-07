using NameListIndexer;

NameList names = new NameList();

names[0] = "Matthew";
names[1] = "Jane";
names[2] = "Pete";

Console.WriteLine("Names in the list:");
PrintNames(names);

names[3] = "Reagan";

Console.WriteLine();
Console.WriteLine("Updated names in the list:");
PrintNames(names);

Console.WriteLine();
Console.WriteLine("Retrieving name at index 5:");
string? retrieved = names[5];
Console.WriteLine(retrieved ?? "Name not found");

static void PrintNames(NameList names)
{
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"Index {i}: {names[i]}");
    }
}
