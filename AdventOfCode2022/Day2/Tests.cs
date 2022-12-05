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
        Assert.Equal(expected, SolverPart1.Execute(lines));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(14531, SolverPart1.Execute(Inputs()));
    }
    
    [Theory]
    [InlineData("A Y,B X,C Z", 12)]
    public void Part2_Example(string input, int expected)
    {
        var lines = input.Split(',');
        Assert.Equal(expected, SolverPart2.Execute(lines));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(11258, SolverPart2.Execute(Inputs()));
    }
}