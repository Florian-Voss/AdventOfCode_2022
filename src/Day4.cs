public class Day4
{
    public static IEnumerable<int[][]> ToIterable2DIntArray(string input){
        return input.Trim().Split("\n").Select(x => x.Split(",")).Select(x => x.Select(x => x.Split("-").Select(x => int.Parse(x)).ToArray()).ToArray());
    }
    public static int SolvePartOne(string input)
    {
        return ToIterable2DIntArray(input).Count(x => (x[0][0] <= x[1][0] && x[0][1] >= x[1][1]) | (x[1][0] <= x[0][0] && x[1][1] >= x[0][1]));
    }
    public static int SolvePartTwo(string input)
    {
        return ToIterable2DIntArray(input).Count(x => (x[0][0] >= x[1][0] && x[0][0] <= x[1][1]) | (x[0][1] >= x[1][0] && x[0][1] <= x[1][1]) | (x[1][0] >= x[0][0] && x[1][0] <= x[0][1]) | (x[1][1] >= x[0][0] && x[1][1] <= x[0][1]));
    }
}