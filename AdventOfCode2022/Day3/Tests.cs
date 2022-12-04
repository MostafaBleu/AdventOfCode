using Xunit;

namespace AdventOfCode2022.Day3;

public class Tests : TestsBase
{
    public override int Day => 3;

    [Fact]
    public void Part1_Example()
    {
        var result = SolverPart1.Execute(Sample());
        Assert.Equal(157, result);
    }
    
    [Fact]
    public void Part1_Real()
    {
        var result = SolverPart1.Execute(Inputs());
        Assert.Equal(8394, result);
    }
    
    [Fact]
    public void Part2_Example()
    {
        var result = SolverPart2.Execute(Sample());
        Assert.Equal(70, result);
    }
    
    [Fact]
    public void Part2_Real()
    {
        var result = SolverPart2.Execute(Inputs());
        Assert.Equal(10, result);
    }
}