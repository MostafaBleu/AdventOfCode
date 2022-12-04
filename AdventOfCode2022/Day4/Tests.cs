using Xunit;

namespace AdventOfCode2022.Day4;

public class Tests : TestsBase
{
    public override int Day => 4;

    [Fact]
    public void Part1_Example()
    {
        var result = SolverPart1.Execute(Sample());
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Part1_Real()
    {
        var result = SolverPart1.Execute(Inputs());
        Assert.Equal(485, result);
    }
    
    [Fact]
    public void Part2_Example()
    {
        var result = SolverPart2.Execute(Sample());
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void Part2_Real()
    {
        var result = SolverPart2.Execute(Inputs());
        Assert.Equal(857, result);
    }
}