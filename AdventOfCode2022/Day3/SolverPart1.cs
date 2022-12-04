namespace AdventOfCode2022.Day3;

public static class SolverPart1
{
    public static int Execute(string[] inputs)
    {
        var sum = 0;
        foreach (var input in inputs)
        {
            var set = new Dictionary<char, int>();
            for (var i = 0; i < input.Length / 2; i++)
            {
                if(!set.ContainsKey(input[i]))
                    set.Add(input[i], 0);
                set[input[i]]++;
            }
            
            for (var i = input.Length / 2 ; i < input.Length; i++)
            {
                if (set.ContainsKey(input[i]))
                {
                    if (input[i] >= 'a' && input[i] <= 'z')
                    {
                        sum += input[i] - 'a' + 1;
                    }
                    else
                    {
                        sum += input[i] - 'A' + 27;
                    }
                    break; // No need to continue there is only one
                }
            }
        }
        return sum;
    }

}