namespace AdventOfCode2022.Day6;

public class SolverPart1
{
    public int Execute(string[] inputs)
    {
        var input = inputs[0];
        return Enumerable.Range(0, input.Length).First(i => input.Substring(i, 4).Distinct().Count() == 4) + 4;
    }
}