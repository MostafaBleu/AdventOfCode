namespace AdventOfCode2022.Day2;

public static class SolverPart1
{
    //A -> Rock  X
    //B -> Paper Y
    // C -> Scissors Z
    
    // Shape + Result
    // 0 -> Draw
    // 3 -> Lost
    // 6 -> Won
    public static int Execute(string[] inputs)
    {
        var Score = 0;

        foreach (var input in inputs)
        {
            var op = input[0];
            var me = input[2];

            Score += Compare(op, me) + handValue[me];

        }
        return Score;
    }

    private static Dictionary<char, int> handValue = new()
    {
        {'X', 1 },
        {'Y', 2 },
        {'Z', 3 }
    };
    
    private static int Compare(char op, char me)
    {
        // He wins
        if (op == 'A' && me == 'Z') return 0;
        if (op == 'B' && me == 'X') return 0;
        if (op == 'C' && me == 'Y') return 0;
        
        //Draw
        if (op == 'A' && me == 'X') return 3;
        if (op == 'B' && me == 'Y') return 3;
        if (op == 'C' && me == 'Z') return 3;

        return 6;
    }

}