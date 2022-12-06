public class Day1
{
    public static IEnumerable<int> SumsOfCalories(string input)
    {
        return input.Split("\n\n").Select(x => x.Split("\n")).Select(x => x.Sum(x =>
        {
            int.TryParse(x, out int y);
            return y;
        }));
    }
    public static int SolvePartOne(string input)
    {
        return SumsOfCalories(input).Max();
    }
    public static int SolvePartTwo(string input)
    {
        return SumsOfCalories(input).OrderByDescending(x => x).Take(3).Sum();
    }
}