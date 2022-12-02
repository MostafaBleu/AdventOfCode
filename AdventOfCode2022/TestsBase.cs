namespace AdventOfCode2022;

public abstract class TestsBase
{
    public abstract int Day { get; }

    public string[] Inputs()
    {
        return File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), $"Day{Day}", "input.txt"));
    }
}