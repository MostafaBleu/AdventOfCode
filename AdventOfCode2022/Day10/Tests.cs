using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day10;

public class Tests : TestsBase
{
    public Tests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    public override int Day => 10;

    [Fact]
    public void Part1_Example()
    {
        Assert.Equal(13140, new SolverPart1().Execute(Sample()));
    }
    
    [Fact]
    public void Part1_Real()
    {
        Assert.Equal(12840, new SolverPart1().Execute(Inputs()));
    }
    
    [Fact]
    public void Part2_Example()
    {
        var result = new SolverPart2().Execute(Sample());
        TestOutputHelper.WriteLine(result);

        var expected = 
            "##  ##  ##  ##  ##  ##  ##  ##  ##  ##  \n"+
            "###   ###   ###   ###   ###   ###   ### \n"+
            "####    ####    ####    ####    ####    \n"+
            "#####     #####     #####     #####     \n"+
            "######      ######      ######      ####\n"+
            "#######       #######       #######     "; 
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Part2_Real()
    {
        var result = new SolverPart2().Execute(Inputs());
        TestOutputHelper.WriteLine(result);
        //ZKJFBJFZ
        var expected = 
            "#### #  #   ## #### ###    ## #### #### \n"+ 
            "   # # #     # #    #  #    # #       # \n"+ 
            "  #  ##      # ###  ###     # ###    #  \n"+ 
            " #   # #     # #    #  #    # #     #   \n"+ 
            "#    # #  #  # #    #  # #  # #    #    \n"+ 
            "#### #  #  ##  #    ###   ##  #    #### ";
        Assert.Equal(expected, result);
        
    }
}