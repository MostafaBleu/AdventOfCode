namespace AdventOfCode2022.Day1;

public static class SolverPart2
{
    public static int Execute(IEnumerable<string> inputs)
    {
        var queue = new SortedSet<int>(Comparer<int>.Create((a, b) => b-a));
        var currentElfTotal = 0;
        
        foreach (var input in inputs)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                queue.Add(currentElfTotal);
                currentElfTotal = 0;
            }
            else
            {
                currentElfTotal += int.Parse(input);
            }
        }
        return queue.Take(3).Sum();
    }
}