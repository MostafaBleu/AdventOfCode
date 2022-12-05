using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day5;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 5;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal("CMZ", new SolverPart1(TestOutputHelper).Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal("BWNCQRMDB", new SolverPart1(TestOutputHelper).Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        Assert.Equal("MCD", new SolverPart2(TestOutputHelper).Execute(Sample()));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal("NHWZCBNBF", new SolverPart2(TestOutputHelper).Execute(Inputs()));
    }
}