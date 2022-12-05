namespace AdventOfCode2022.Day3;

public static class SolverPart1
{
    public static int Execute(string[] inputs)
    {
        return inputs.Sum(FindDuplicate);
    }

    private static int FindDuplicate(string input)
    {
        var set = new HashSet<char>();
        for (var i = 0; i < input.Length / 2; i++)
        {
            set.Add(input[i]);
        }
            
        for (var i = input.Length / 2 ; i < input.Length; i++)
        {
            if (set.Contains(input[i]))
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    return  input[i] - 'a' + 1;
                }
                return  input[i] - 'A' + 27;
            }
        }
        return 0;
    }
}