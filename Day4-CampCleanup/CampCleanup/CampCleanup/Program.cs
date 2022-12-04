
var campData = File.ReadAllLines("C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2022\\Day4-CampCleanup\\CampData.txt");

var total = 0;

foreach (var line in campData)
{
    var areas = line.Split(",");

    var area1 = areas[0].Split("-");
    var area2 = areas[1].Split("-");

    if (int.Parse(area1[0]) >= int.Parse(area2[0])
        && int.Parse(area1[1]) <= int.Parse(area2[1]))
    {
        total++;
        continue;
    }
    
    if (int.Parse(area1[0]) <= int.Parse(area2[0])
        && int.Parse(area1[1]) >= int.Parse(area2[1]))
    {
        total++;
    }
}

Console.WriteLine(total);

//Part 2
foreach (var line in campData)
{
    var areas = line.Split(",");

    var area1 = areas[0].Split("-");
    var area2 = areas[1].Split("-");

    if (int.Parse(area1[0]) >= int.Parse(area2[0])
        && int.Parse(area1[0]) <= int.Parse(area2[1]))
    {
        total++;
        continue;
    }

    if (int.Parse(area1[0]) <= int.Parse(area2[0])
        && int.Parse(area1[1]) >= int.Parse(area2[0]))
    {
        total++;
    }
}