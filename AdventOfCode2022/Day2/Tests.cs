using Xunit;

namespace AdventOfCode2022.Day2;

public class Tests : TestsBase
{
    public override int Day => 2;

    [Theory]
    [InlineData("A Y,B X,C Z", 15)]
    public void Part1_Example(string input, int expected)
    {
        var lines = input.Split(',');
        var result = SolverPart1.Execute(lines);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Part1_Real()
    {
        var result = SolverPart1.Execute(Inputs());
        Assert.Equal(14531, result);
    }
    
    [Theory]
    [InlineData("A Y,B X,C Z", 12)]
    public void Part2_Example(string input, int expected)
    {
        var lines = input.Split(',');
        var result = SolverPart2.Execute(lines);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Part2_Real()
    {
        var result = SolverPart2.Execute(Inputs());
        Assert.Equal(11258, result);
    }
}