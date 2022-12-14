using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day0;

public class Tests
{
    private readonly ITestOutputHelper _testOutputHelper;
    
    private readonly string[] _realData = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Day0", "input.txt"));

    public Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory]
    [InlineData("199", 0)]
    [InlineData(null, 0)]
    public void Part1(string? input, int expected)
    {
        _testOutputHelper.WriteLine(_realData.FirstOrDefault());
        var lines = input != null ? input.Split(',') : _realData;
        var result = new Solver().Execute(lines, false);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("199,200,208,210,200,207,240,269,260,263", 0)]
    [InlineData(null, 0)]
    public void Part2(string? input, int expected)
    {
        _testOutputHelper.WriteLine(_realData.FirstOrDefault());
        var lines = input != null ? input.Split(',') : _realData;
        var result = new Solver().Execute(lines, false);
        Assert.Equal(expected, result);
    }
}

