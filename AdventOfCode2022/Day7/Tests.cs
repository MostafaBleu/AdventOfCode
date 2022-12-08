using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day7;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 7;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(95437, new SolverPart1(TestOutputHelper).Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(1778099, new SolverPart1(TestOutputHelper).Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal(24933642, new SolverPart2(TestOutputHelper).Execute(Sample()));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(1623571, new SolverPart2(TestOutputHelper).Execute(Inputs()));
    }
}