namespace AdventOfCode2022.Day10;

public class SolverPart1
{
    public  int Execute(string[] lines)
    {
        var markCycles = new[] {20, 60, 100, 140, 180, 220};
        var markedSignalStrengths = new List<int>();
        var cyclesElapsed = 0;
        var reg = 1;
        foreach (var line in lines)
        {
            if (line.StartsWith("noop"))
            {
                cyclesElapsed += 1;
                if (markCycles.Contains(cyclesElapsed)) 
                    markedSignalStrengths.Add(cyclesElapsed * reg);
            }
            else
            { 
                // add operation takes 2 cycles, only updates signal strength AFTER
                cyclesElapsed += 1;
                if (markCycles.Contains(cyclesElapsed))
                    markedSignalStrengths.Add(cyclesElapsed * reg);
                cyclesElapsed += 1;
                if (markCycles.Contains(cyclesElapsed)) 
                    markedSignalStrengths.Add(cyclesElapsed * reg);
                var value = int.Parse(line.Split(" ")[1]);
                reg += value;
            }
        }
        return markedSignalStrengths.Sum();
    }
}