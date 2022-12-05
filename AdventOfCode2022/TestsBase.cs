using Xunit.Abstractions;
using Xunit.Sdk;

namespace AdventOfCode2022;

public abstract class TestsBase
{
    internal readonly ITestOutputHelper TestOutputHelper;
    
    public TestsBase(ITestOutputHelper? testOutputHelper = null)
    {
        TestOutputHelper = testOutputHelper ?? new TestOutputHelper();
    }
    
    public abstract int Day { get; }

    public string[] Inputs()
    {
        return File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), $"Day{Day}", "input.txt"));
    }
    
    public string[] Sample()
    {
        return File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), $"Day{Day}", "sample.txt"));
    }
}