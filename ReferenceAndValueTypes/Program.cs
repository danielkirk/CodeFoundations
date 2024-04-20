// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine(DaysOfWeek.Monday);

DaysOfWeek mondayEnum3;

bool parsed = Enum.TryParse<DaysOfWeek>("Monday", out mondayEnum3);

Console.WriteLine($"Enum {(parsed ? "Was Parsed" : "Was not parsed")}: {mondayEnum3}");

foreach(DaysOfWeek values in Enum.GetValues(typeof(DaysOfWeek)))
{
    Console.WriteLine((int)values);
}

foreach (string values in Enum.GetNames(typeof(DaysOfWeek)))
{
    Console.WriteLine(values);
}
Permissions p = Permissions.Read | Permissions.Write;
Console.WriteLine(p);

bool canRead = (p & Permissions.Read) == Permissions.Read;
bool canWrite = (p & Permissions.Write) == Permissions.Write;
bool canExecute = (p & Permissions.Execute) == Permissions.Execute;
Console.WriteLine($"Can read: {canRead}");
Console.WriteLine($"Can write: {canWrite}");
Console.WriteLine($"Can execute: {canExecute}");

[Flags]
enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

enum DaysOfWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
};