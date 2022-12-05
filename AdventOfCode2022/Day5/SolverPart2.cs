using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day5;

public class SolverPart2
{
    private readonly ITestOutputHelper _output;
    public SolverPart2(ITestOutputHelper output)
    {
        _output = output;
    }
    
    private readonly Dictionary<int, LinkedList<char>> _stacks = new ();
    private readonly Regex _moveRegex = new (@"move ([0-9]*) from ([0-9]) to ([0-9])");
    

    public string Execute(string[] inputs)
    {
        foreach (var input in inputs)
        {
            if (input.Contains("["))
            {
                ParseCranes(input);
                continue;
            }
            var match = _moveRegex.Match(input);
            if (match.Success)
            {
                var count = int.Parse(match.Groups[1].Value);
                var from = int.Parse(match.Groups[2].Value);
                var to = int.Parse(match.Groups[3].Value);
                Move(count, from, to);
            }
        }
        return string.Join("", _stacks.Values.Select(s => s.First.Value));
    }

    private void Move(int count, int from, int to)
    {
        var items = _stacks[from - 1].Take(count).ToList();
        for (var i = count-1; i >=0 ; i--)
        {
            _stacks[from - 1].RemoveFirst();
            _stacks[to-1].AddFirst(items[i]);
        }
    }
    private void ParseCranes(string input)
    {
        for (var i = 0; i <= input.Length/4; i++)
        {
            if(!_stacks.ContainsKey(i))
                _stacks.Add(i, new LinkedList<char>());
            var index = 4 * i + 1;
            if(char.IsLetter(input[index]))
                _stacks[i].AddLast(input[index]);
        }
    }
}