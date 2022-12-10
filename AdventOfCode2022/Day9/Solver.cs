using System.Diagnostics;

namespace AdventOfCode2022.Day9;

public class Solver
{
    [DebuggerDisplay("{X}, {Y}")]
    private struct Position
    {
        public int X;
        public int Y;

        public void MoveToBeAdjacentTo(Position h)
        {
            var xDir = h.X - X;
            var yDir = h.Y - Y;

            // if we're already adjacent (no more than 1 away along either axis), return
            if (Math.Max(Math.Abs(xDir), Math.Abs(yDir)) <= 1) return;

            Debug.Assert(Math.Abs(xDir) == 2 || Math.Abs(yDir) == 2);
            Debug.Assert(Math.Max(Math.Abs(xDir), Math.Abs(yDir)) == 2);

            xDir = Math.Clamp(xDir, -1, 1);
            yDir = Math.Clamp(yDir, -1, 1);

            X += xDir;
            Y += yDir;
        }
    }
    
    public  int Execute(string[] lines, int ropeCount)
    {
        var tailSet = new HashSet<Position>();
        var rope = new Position[ropeCount];

        tailSet.Add(rope.Last());

        foreach (var line in lines)
        {
            var xDir = 0;
            var yDir = 0;
        
            var split = line.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            Debug.Assert(split.Length == 2);
            var stepCount = int.Parse(split[1]);
            switch (split[0])
            {
                case "R": xDir =  1; break;
                case "L": xDir = -1; break;
                case "U": yDir =  1; break;
                case "D": yDir = -1; break;
                default: Debug.Assert(false); break;
            }

            for (var i = 0; i < stepCount; i++)
            {
                rope[0].X += xDir;
                rope[0].Y += yDir;

                for (var j = 1; j < rope.Length; j++)
                { rope[j].MoveToBeAdjacentTo(rope[j - 1]); }

                tailSet.Add(rope.Last());
            }
        }
        return tailSet.Count;
    }
}