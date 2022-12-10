using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day9;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 9;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(13, new Solver().Execute(Sample(), 2));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(6337, new Solver().Execute(Inputs(), 2));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal(1, new Solver().Execute(Sample(), 10));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(2455, new Solver().Execute(Inputs(), 10));
    }
}