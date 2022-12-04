namespace AdventOfCode2022.Day3;

public static class SolverPart1
{
    /*
     * a = 97  z=122
     * A = 65  Z=90
     */
    public static int Execute(string[] inputs)
    {
        var sum = 0;
        foreach (var input in inputs)
        {
            var set = new Dictionary<char, int>();
            //Count items in compartment 1
            for (int i = 0; i < input.Length / 2; i++)
            {
                if(!set.ContainsKey(input[i]))
                    set.Add(input[i], 0);
                set[input[i]]++;
            }
            
            //
            for (int i = input.Length / 2 ; i < input.Length; i++)
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
                    break;
                }
            }
        }
        return sum;
    }

}