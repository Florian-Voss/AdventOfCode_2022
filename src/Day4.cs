public class Day4
{
    public static int SolvePartOne(string input)
    {
        return input.Trim().Split("\n").Select(x => x.Split(",")).Select(x => x.Select(x => x.Split("-").Select(x => int.Parse(x)).ToArray()).ToArray()).Count(x => (x[0][0] <= x[1][0] && x[0][1] >= x[1][1]) | (x[1][0] <= x[0][0] && x[1][1] >= x[0][1]));
    }
    public static int SolvePartTwo(string input)
    {
        return input.Trim().Split("\n").Select(x => x.Split(",")).Select(x => x.Select(x => x.Split("-").Select(x => int.Parse(x)).ToArray()).ToArray()).Count(x => (x[0][0] >= x[1][0] && x[0][0] <= x[1][1]) | (x[0][1] >= x[1][0] && x[0][1] <= x[1][1]) | (x[1][0] >= x[0][0] && x[1][0] <= x[0][1]) | (x[1][1] >= x[0][0] && x[1][1] <= x[0][1]));
    }
}