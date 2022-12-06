public class Day3
{
    public static int SolvePartOne(string input)
    {
        var result = 0;
        foreach (var item in input.Split("\n"))
        {
            var compartment1 = item.Substring(0, item.Length / 2);
            var compartment2 = item.Substring(item.Length / 2, item.Length / 2);
            var intersection = compartment1.Intersect(compartment2);
            result += intersection.Select(GetPriority).Sum();
        }
        return result;
    }
    public static int SolvePartTwo(string input)
    {
        var array = input.Trim().Split("\n");
        var result = 0;
        for (int i = 0; i < array.Length; i += 3)
        {
            var bagIntersection = array[i].Intersect(array[i + 1]).Intersect(array[i + 2]);
            result += bagIntersection.Select(GetPriority).Sum();
        }
        return result;
    }
    public static int GetPriority(char c)
    {
        var result = 0;
        if (char.IsLower(c))
        {
            result += c - 'a' + 1;
        }
        else if (char.IsUpper(c))
        {
            result += c - 'A' + 27;
        }
        return result;
    }
}