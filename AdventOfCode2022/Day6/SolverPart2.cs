namespace AdventOfCode2022.Day6;

public class SolverPart2
{
    public int Execute(string[] inputs)
    {
        var input = inputs[0];
        return Enumerable.Range(0, input.Length).First(i => input.Substring(i, 14).Distinct().Count() == 14) + 14;
    }
}