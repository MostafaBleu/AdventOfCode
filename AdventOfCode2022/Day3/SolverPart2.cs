namespace AdventOfCode2022.Day3;

public static class SolverPart2
{
    public static int Execute(string[] inputs)
    {
        var sum = 0;
        for (var g = 0; g < inputs.Length; g= g+3 )
        {
            var set = new Dictionary<char, int>();
            CountGroup(set, inputs[g]);
            CountGroup(set, inputs[g+1]);
            CountGroup(set, inputs[g+2]);
            var pair = set.First(p => p.Value == 3);
            if (pair.Key >= 'a' && pair.Key <= 'z')
            {
                sum += pair.Key - 'a' + 1;
            }
            else
            {
                sum += pair.Key - 'A' + 27;
            }
        }
        return sum;
    }

    private static void CountGroup(Dictionary<char, int> counter, string input )
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