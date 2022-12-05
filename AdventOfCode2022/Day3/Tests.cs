using Xunit;

namespace AdventOfCode2022.Day3;

public class Tests : TestsBase
{
    public override int Day => 3;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(157, SolverPart1.Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(8394, SolverPart1.Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal(70, SolverPart2.Execute(Sample()));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(2413, SolverPart2.Execute(Inputs()));
    }
}