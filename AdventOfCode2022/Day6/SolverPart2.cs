namespace AdventOfCode2022.Day6;

public class SolverPart2
{
    public int Execute(string[] inputs)
    {
        var input = inputs[0];
        for (var i = 0; i < input.Length - 14; i++)
        {
            if (input.Substring(i, 14).Distinct().Count() == 14)
                return i + 14;
        }
        return -1;
    }
}