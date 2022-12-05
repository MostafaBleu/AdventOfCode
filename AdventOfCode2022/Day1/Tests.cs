using Xunit;

namespace AdventOfCode2022.Day1;

public class Tests : TestsBase
{
    public override int Day => 1;
    
    [Theory]
    [InlineData("1000,2000,3000,,4000,5000,6000,,7000,8000,9000,,10000", 24000)]
    [InlineData(null, 71124)]
    public void Part1(string? input, int expected)
    {
        var lines = input != null ? input.Split(',') : Inputs();
        Assert.Equal(expected, SolverPart1.Execute(lines));
    }
    
    [Theory]
    [InlineData("1000,2000,3000,,4000,5000,6000,,7000,8000,9000,,10000", 45000)]
    [InlineData(null, 204639)]
    public void Part2(string? input, int? expected)
    {
        var lines = input != null ? input.Split(',') : Inputs();
        Assert.Equal(expected, SolverPart2.Execute(lines));
    }
}