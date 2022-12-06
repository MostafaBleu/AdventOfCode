using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day6;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 6;

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void Part1_Example(string input, int expected)
    {
        Assert.Equal(expected, new SolverPart1().Execute(new []{input}));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(1702, new SolverPart1().Execute(Inputs()));
    }
    
    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
    public void Part2_Example(string input, int expected)
    {
        Assert.Equal(expected, new SolverPart2().Execute(new []{input}));
    }
    
    [Fact]
    public void Part2_Real()
    {
        Assert.Equal(3559, new SolverPart2().Execute(Inputs()));
    }
}