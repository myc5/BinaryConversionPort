// Rewriting my very first Python App in C# -> Convert between Base 2 and Base 10 units
// ToDo: Allow conversion from units of different "tiers", based on the size of the result

do 
{
string choiceValue = "";
Console.WriteLine("Please enter the value you want to convert without units: ");
float val;

while (true)
{
    choiceValue = Console.ReadLine();
    if (float.TryParse(choiceValue, out float c))
    {
        val = c;
        break;
    }
    continue;
}

Console.WriteLine("[1] Convert from Base 10 to Base 2 [i.e. MB to MiB]\n[2] Convert from Base 2 to Base 10 [i.e. MiB to MB]");

string choiceBase = "";

while (choiceBase != "1" && choiceBase != "2")
{
    choiceBase = Console.ReadLine();
}

string choiceUnit = "";

if (choiceBase == "1")
{
    Console.WriteLine("Converting from Base 10 to Base 2.\nPlease pick the unit to convert from:\n[1]KB\n[2]MB\n[3]GB\n[4]TB");
    while (choiceUnit != "1" && choiceUnit != "2" && choiceUnit != "3" && choiceUnit != "4")
    {
        choiceUnit = Console.ReadLine();
    }

    switch (choiceUnit)
    {
        case "1":
            Console.WriteLine($"{val:F3} KB converts to {val * Math.Pow(10, 3) / Math.Pow(2, 10):F3} KiB");
            break;
        case "2":
            Console.WriteLine($"{val:F3} MB converts to {val * Math.Pow(10, 6) / Math.Pow(2, 20):F3} MiB");
            break;
        case "3":
            Console.WriteLine($"{val:F3} GB converts to {val * Math.Pow(10, 9) / Math.Pow(2, 30):F3} GiB");
            break;
        case "4":
            Console.WriteLine($"{val:F3} TB converts to {val * Math.Pow(10, 12) / Math.Pow(2, 40):F3} TiB");
            break;

    }
}
if (choiceBase == "2")
{
    Console.WriteLine("Converting from Base 2 to Base 10.\nPlease pick the unit to convert from:\n[1]KiB\n[2]MiB\n[3]GiB\n[4]TiB");
    while (choiceUnit != "1" && choiceUnit != "2" && choiceUnit != "3" && choiceUnit != "4")
    {
        choiceUnit = Console.ReadLine();
    }

    switch (choiceUnit)
    {
        case "1":
            Console.WriteLine($"{val:F3} KiB converts to {val * Math.Pow(2, 10) / Math.Pow(10, 3):F3} KB");
            break;
        case "2":
            Console.WriteLine($"{val:F3} MiB converts to {val * Math.Pow(2, 20) / Math.Pow(10, 6):F3} MB");
            break;
        case "3":
            Console.WriteLine($"{val:F3} GiB converts to {val * Math.Pow(2, 30) / Math.Pow(10, 9):F3} GB");
            break;
        case "4":
            Console.WriteLine($"{val:F3} TiB converts to {val * Math.Pow(2, 40) / Math.Pow(10, 12):F3} TB");
            break;

    }

}
Console.WriteLine("Rerun? [Y/n]");
 } while (Console.ReadLine() != "n");





