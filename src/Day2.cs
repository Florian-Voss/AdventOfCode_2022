public class Day2
{
    public static int ScoreOfRockPaperScissorsPartOne(char x, char y)
    {
        int score = 0;
        if ((x != 'A' && x != 'B' && x != 'C') | (y != 'X' && y != 'Y' && y != 'Z'))
        {
            throw new ArgumentException("Invalid Input");
        }
        if ((x == 'A' && y == 'Y') | (x == 'B' && y == 'Z') | (x == 'C' && y == 'X'))
        {
            score += 6;
        }
        else if ((x == 'A' && y == 'X') | (x == 'B' && y == 'Y') | (x == 'C' && y == 'Z'))
        {
            score += 3;
        }
        if (y == 'X')
        {
            score += 1;
        }
        else if (y == 'Y')
        {
            score += 2;
        }
        else if (y == 'Z')
        {
            score += 3;
        }
        return score;
    }
    public static int ScoreOfRockPaperScissorsPartTwo(char x, char y)
    {
        int score = 0;
        if ((x != 'A' && x != 'B' && x != 'C') | (y != 'X' && y != 'Y' && y != 'Z'))
        {
            throw new ArgumentException("Invalid Input");
        }
        if (y == 'Z')
        {
            if (x == 'A')
            {
                score += 2;
            }
            else if (x == 'B')
            {
                score += 3;
            }
            else if (x == 'C')
            {
                score += 1;
            }
            score += 6;
        }
        else if (y == 'Y')
        {
            if (x == 'A')
            {
                score += 1;
            }
            else if (x == 'B')
            {
                score += 2;
            }
            else if (x == 'C')
            {
                score += 3;
            }
            score += 3;
        }
        else if (y == 'X')
        {
            if (x == 'A')
            {
                score += 3;
            }
            else if (x == 'B')
            {
                score += 1;
            }
            else if (x == 'C')
            {
                score += 2;
            }
        }
        return score;
    }
    public static int SolvePartOne(string input){
        return input.Trim().Split("\n").Select(x => ScoreOfRockPaperScissorsPartOne(x[0], x[2])).Sum();
    }
    public static int SolvePartTwo(string input){
        return input.Trim().Split("\n").Select(x => ScoreOfRockPaperScissorsPartTwo(x[0], x[2])).Sum();
    }
}