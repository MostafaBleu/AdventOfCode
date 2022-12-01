namespace AdventOfCode2022.Day1;

public static class SolverPart2
{
    public static int Execute(IEnumerable<string> inputs)
    {
        var set = new SortedSet<int>(Comparer<int>.Create((a, b) => b-a));
        var currentElfTotal = 0;
        
        foreach (var input in inputs)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                set.Add(currentElfTotal);
                currentElfTotal = 0;
            }
            else
            {
                currentElfTotal += int.Parse(input);
            }
        }
        return set.Take(3).Sum();
    }
}