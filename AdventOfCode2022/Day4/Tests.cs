using Xunit;

namespace AdventOfCode2022.Day4;

public class Tests : TestsBase
{
    public override int Day => 4;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(2, SolverPart1.Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(485, SolverPart1.Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal(4, SolverPart2.Execute(Sample()));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(857, SolverPart2.Execute(Inputs()));
    }
}