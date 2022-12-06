public class Program
{
    public static async Task Main(string[] args)
    {
        //----------- Day 1 -----------
        var data_Day1 = await DataProvider.GetDataFromDay(1);
        var solutionDay1Part1 = Day1.SolvePartOne(data_Day1);
        var solutionDay1Part2 = Day1.SolvePartTwo(data_Day1);
        Console.WriteLine(solutionDay1Part1);
        Console.WriteLine(solutionDay1Part2);
        //----------- Day 1 -----------
        
        //----------- Day 2 -----------
        var data_Day2 = await DataProvider.GetDataFromDay(2);
        var solutionDay2Part1 = Day2.SolvePartOne(data_Day2);
        var solutionDay2Part2 = Day2.SolvePartTwo(data_Day2);
        Console.WriteLine(solutionDay2Part1);
        Console.WriteLine(solutionDay2Part2);
        //----------- Day 2 -----------

        //----------- Day 3 -----------
        var data_Day3 = await DataProvider.GetDataFromDay(3);
        var solutionDay3Part1 = Day3.SolvePartOne(data_Day3);
        var solutionDay3Part2 = Day3.SolvePartTwo(data_Day3);
        Console.WriteLine(solutionDay3Part1);
        Console.WriteLine(solutionDay3Part2);
        //----------- Day 3 -----------
        
        //----------- Day 4 -----------
        var data_Day4 = await DataProvider.GetDataFromDay(4);
        var solutionDay4Part1 = Day4.SolvePartOne(data_Day4);
        var solutionDay4Part2 = Day4.SolvePartTwo(data_Day4);
        Console.WriteLine(solutionDay4Part1);
        Console.WriteLine(solutionDay4Part2);
        //----------- Day 4 -----------
    }
}