namespace AdventOfCode2022.Day3;

public static class SolverPart2
{
    /*
     * a = 97  z=122
     * A = 65  Z=90
     */
    public static int Execute(string[] inputs)
    {
        var sum = 0;
        
        for (int g = 0; g < inputs.Length; g= g+3 )
        {
            var group1 = inputs[g];
            var group2 = inputs[g+1];
            var group3 = inputs[g+2];
            
            var set = new Dictionary<char, int>();

            CountGroup(set, group1, 1);
            CountGroup(set, group2, 2);
            CountGroup(set, group3, 3);

            foreach (var pair in set)
            {
                
                if (pair.Value >= 3)
                {
                    if (pair.Key >= 'a' && pair.Key <= 'z')
                    {
                        sum += pair.Key - 'a' + 1;
                    }
                    else
                    {
                        sum += pair.Key - 'A' + 27;
                    }
                    break;
                }
            }
        }
        return sum;
    }

    private static void CountGroup(Dictionary<char, int> counter, string input, int member )
    {
        var set = new HashSet<char>();
        foreach (var item in input)
        {
            if(!counter.ContainsKey(item))
                counter.Add(item, 0);
            
            if (!set.Contains(item))
            {
                counter[item]++;
                set.Add(item);
            }
            
        }
    }

}