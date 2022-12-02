namespace AdventOfCode2022.Day2;

public static class SolverPart2
{
    private const char ME_ROCKK = 'X';
    private const char ME_PAPER = 'Y';
    private const char ME_SCISS = 'Z';
    
    private const char OP_ROCKK = 'A';
    private const char OP_PAPER = 'B';
    private const char OP_SCISS = 'C';
    
    
    public static int Execute(string[] inputs)
    {
        var Score = 0;
        foreach (var input in inputs)
        {
            var op = input[0];
            var dec = input[2];
            var me = Compare(op, dec);
            Score += RoundScore[dec] + HandValue[me];
        }
        return Score;
    }

    
    private static readonly Dictionary<char, int> HandValue = new()
    {
        {ME_ROCKK, 1 },
        {ME_PAPER, 2 },
        {ME_SCISS, 3 }
    };
    
    // Shape + Result
    // 0 -> Draw
    // 3 -> Lost 
    // 6 -> Won 
    private static readonly Dictionary<char, int> RoundScore = new()
    {
        {'X', 0 }, // Draw
        {'Y', 3 }, // Lost
        {'Z', 6 }  // Win
    };
    
    private static readonly Dictionary<char, char> Win = new()
    {
        {OP_PAPER, ME_SCISS},
        {OP_SCISS, ME_ROCKK},
        {OP_ROCKK, ME_PAPER }
    };
    
    private static readonly Dictionary<char, char> Lose = new()
    {
        {OP_PAPER, ME_ROCKK},
        {OP_SCISS, ME_PAPER},
        {OP_ROCKK, ME_SCISS }
    };
    
    private static readonly Dictionary<char, char> Draw = new()
    {
        {OP_PAPER, ME_PAPER},
        {OP_SCISS, ME_SCISS},
        {OP_ROCKK, ME_ROCKK }
    };
    
    private static char Compare(char op, char dec)
    {
        if (dec == 'X')
            return Lose[op];
        if (dec == 'Y')
            return Draw[op];
        return Win[op];
    }

}