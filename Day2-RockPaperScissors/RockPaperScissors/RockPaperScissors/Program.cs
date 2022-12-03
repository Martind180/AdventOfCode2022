//Opponent
//A = rock
//B = paper
//C = scissors

//Ours
//X = rock = 1 point
//Y = paper = 2 points
//Z = scissors = 3 points

//lose = 0 points
//draw = 3 points
//win = 6 points

const int x = 1;
const int y = 2;
const int z = 3;

const int win = 6;
const int draw = 3;

const string path = "C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2022\\Day2-RockPaperScissors\\GameData.txt";

var gameData = File.ReadAllLines(path);

var totalScore = 0;

foreach (var line in gameData)
{
    var lineWithoutSpaces = string.Concat(line.Where(s => !char.IsWhiteSpace(s)));

    var opponent = lineWithoutSpaces[0];
    var me = lineWithoutSpaces[1];

    switch (opponent)
    {
        case 'A':
            switch (me)
            {
                case 'X':
                    //draw
                    totalScore += x + draw;
                    break;
                
                case 'Y':
                    //win
                    totalScore += y + win;
                    break;
                
                case 'Z':
                    //lose
                    totalScore += z;
                    break;
            }
            break;
        
        case 'B':
            switch (me)
            {
                case 'X':
                    //lose
                    totalScore += x;
                    break;
                
                case 'Y':
                    //draw
                    totalScore += y + draw;
                    break;
                
                case 'Z':
                    //win
                    totalScore += z + win;
                    break;
            }
            break;
        
        case 'C':
            switch (me)
            {
                case 'X':
                    //win
                    totalScore += x + win;
                    break;
                
                case 'Y':
                    //lose
                    totalScore += y;
                    break;
                
                case 'Z':
                    //draw
                    totalScore += z + draw;
                    break;
            }
            break;
    }
}

Console.WriteLine("Part 1: " + totalScore);

//-------PART TWO----------
//x = lose
//y = draw
//z = win

//Opponent
//A = rock
//B = paper
//C = scissors

const int rock = 1;
const int paper = 2;
const int scissors = 3;

totalScore = 0;

foreach (var line in gameData)
{
    var lineWithoutSpaces = string.Concat(line.Where(s => !char.IsWhiteSpace(s)));

    var opponent = lineWithoutSpaces[0];
    var me = lineWithoutSpaces[1];

    switch (opponent)
    {
        case 'A':
            switch (me)
            {
                case 'X':
                    //lose
                    totalScore += scissors;
                    break;
                
                case 'Y':
                    //draw
                    totalScore += rock + draw;
                    break;
                
                case 'Z':
                    //win
                    totalScore += paper + win;
                    break;
            }
            break;
        
        case 'B':
            switch (me)
            {
                case 'X':
                    //lose
                    totalScore += rock;
                    break;
                
                case 'Y':
                    //draw
                    totalScore += paper + draw;
                    break;
                
                case 'Z':
                    //win
                    totalScore += scissors + win;
                    break;
            }
            break;
        
        case 'C':
            switch (me)
            {
                case 'X':
                    //lose
                    totalScore += paper;
                    break;
                
                case 'Y':
                    //draw
                    totalScore += scissors + draw;
                    break;
                
                case 'Z':
                    //win
                    totalScore += rock + win;
                    break;
            }
            break;
    }
}

Console.WriteLine("Part 2: " + totalScore);