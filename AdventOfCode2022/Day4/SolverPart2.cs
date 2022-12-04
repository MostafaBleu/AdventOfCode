using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day4;

public static class SolverPart2
{
    public static int Execute(string[] inputs)
    {
        var sum = 0;
        var regex = new Regex(@"(.*)-(.*),(.*)-(.*)");
        foreach (var input in inputs)
        {
            var match = regex.Match(input);
            var x1 = int.Parse(match.Groups[1].Value);
            var x2 = int.Parse(match.Groups[2].Value);
            var y1 = int.Parse(match.Groups[3].Value);
            var y2 = int.Parse(match.Groups[4].Value);

            if (x2 >= y1 && y2 >= x1)
                sum += 1;
        }
        return sum;
    }
}