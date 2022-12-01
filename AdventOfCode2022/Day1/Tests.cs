using Xunit;

namespace AdventOfCode2022.Day1;

public class Tests
{
    private readonly string[] _realData = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Day1", "input.txt"));
    
    [Theory]
    [InlineData("1000,2000,3000,,4000,5000,6000,,7000,8000,9000,,10000", 24000)]
    [InlineData(null, 71124)]
    public void Part1(string? input, int expected)
    {
        var lines = input != null ? input.Split(',') : _realData;
        var result = SolverPart1.Execute(lines);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1000,2000,3000,,4000,5000,6000,,7000,8000,9000,,10000", 45000)]
    [InlineData(null, 204639)]
    public void Part2(string? input, int? expected)
    {
        var lines = input != null ? input.Split(',') : _realData;
        var result = SolverPart2.Execute(lines);
        Assert.Equal(expected, result);
    }
}