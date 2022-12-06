namespace AdventOfCode2022.Day6;

public class SolverPart1
{
    public int Execute(string[] inputs)
    {
        var input = inputs[0];
        for (var i = 0; i < input.Length - 4; i++)
        {
            if (input.Substring(i, 4).Distinct().Count() == 4)
                return i +4;
        }
        return -1;
    }
}