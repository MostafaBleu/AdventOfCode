using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day8;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 8;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(21, new SolverPart1().Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(1695, new SolverPart1().Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal(8, new SolverPart2().Execute(Sample()));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(287040, new SolverPart2().Execute(Inputs()));
    }
}