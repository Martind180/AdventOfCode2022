//Part 1
var backpackData = File.ReadAllLines("C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2022\\Day3-BackpackSorter\\BackpackData.txt");

var total = 0;

foreach (var line in backpackData)
{
    var numberOfItemsPerCompartment = line.Length / 2;

    var firstCompartment = line[..numberOfItemsPerCompartment];
    var secondCompartment = line.Substring(numberOfItemsPerCompartment, numberOfItemsPerCompartment);

    foreach (var item in firstCompartment.Where(item => secondCompartment.Contains(item)))
    {
        if (char.IsUpper(item))
        {
            total += item % 32 + 26;
            break;
        }
        total += item % 32;
        break;
    }
}

Console.WriteLine("Part 1: " + total);

//Part 2
total = 0;

for (var i = 0; i < backpackData.Length; i += 3)
{
    foreach (var item in backpackData[i]
                 .Where(item => backpackData[i + 1].Contains(item) && backpackData[i + 2].Contains(item)))
    {
        if (char.IsUpper(item))
        {
            total += item % 32 + 26;
            break;
        }
        total += item % 32;
        break;
    }
}

Console.WriteLine("Part 2: " + total);