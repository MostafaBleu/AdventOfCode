namespace AdventOfCode2022.Day1;

public static class SolverPart1
{
    public static int Execute(string[] inputs)
    {
        var maxCalories = 0;
        var currentElfTotal = 0;
        
        foreach (var input in inputs)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                maxCalories = Math.Max(maxCalories, currentElfTotal);
                currentElfTotal = 0;
            }
            else
            {
                currentElfTotal += int.Parse(input);
            }
        }
        return maxCalories;
    }
}