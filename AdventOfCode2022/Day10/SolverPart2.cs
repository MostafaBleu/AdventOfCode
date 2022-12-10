namespace AdventOfCode2022.Day10;

public class SolverPart2
{
    private const char DARK = ' ';
    private const char LIHGT = '#';
    private const int SCREEN_SIZE = 40;
    private const int SCREEN_LINES = 6;

    private const int TOTAL_PIXELS = SCREEN_SIZE * SCREEN_LINES;

    public string Execute(string[] lines)
    {

        var cyclesElapsed = 0;
        var reg = 1;

        var crt = Enumerable.Range(0, TOTAL_PIXELS).Select(i => DARK).ToList();
        
        foreach (var line in lines)
        {
            if (line.StartsWith("noop"))
            {
                var pixelX = (cyclesElapsed) % SCREEN_SIZE;
                if (Math.Abs(reg - pixelX) <= 1)
                    crt[cyclesElapsed % TOTAL_PIXELS] = LIHGT;
                else
                    crt[cyclesElapsed % TOTAL_PIXELS] = DARK;
                cyclesElapsed += 1;
            }
            else
            {
                var pixelX = cyclesElapsed % SCREEN_SIZE;
                if (Math.Abs(reg - pixelX) <= 1)
                    crt[cyclesElapsed % TOTAL_PIXELS] = LIHGT;
                else 
                    crt[cyclesElapsed % TOTAL_PIXELS] = DARK;
                cyclesElapsed += 1;
                pixelX = cyclesElapsed % SCREEN_SIZE;
                if (Math.Abs(reg - pixelX) <= 1)
                    crt[cyclesElapsed % TOTAL_PIXELS] = LIHGT;
                else
                    crt[cyclesElapsed % TOTAL_PIXELS] = DARK;
                cyclesElapsed += 1;

                var value = int.Parse(line.Split(" ")[1]);
                reg += value;
            }
        }

        var crts = string.Join("",crt);
        var list = Range(0, TOTAL_PIXELS, SCREEN_SIZE)
            .Select(i => crts.Substring(i,  SCREEN_SIZE)).ToList();
        return string.Join("\n", list);
        
    }
    
    public static IEnumerable<int> Range(int start, int stop, int step)
    {
        var x = start;
        do
        {
            yield return x;
            x += step;
            if (step < 0 && x <= stop || 0 < step && stop <= x)
                break;
        }
        while (true);
    }
}