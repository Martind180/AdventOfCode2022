//part 1 find the highest total
var file = new List<string>(
    File.ReadAllLines(
        "C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2022\\Day1-CalorieCounting\\CalorieList.txt"));

var calorieCount = 0;

var calorieList = new List<int>();

foreach (var line in file)
{
    if (string.IsNullOrWhiteSpace(line))
    {
        calorieList.Add(calorieCount);
        calorieCount = 0;
        continue;
    }

    calorieCount += int.Parse(line);
}

var highestCalories = calorieList.Max();

//Part 2 find total of the top 3
calorieList.Sort();
calorieList.Reverse();

var topThree = calorieList.Take(3);

var total = topThree.Sum();

Console.WriteLine(total);