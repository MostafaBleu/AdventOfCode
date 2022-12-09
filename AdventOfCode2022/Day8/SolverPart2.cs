namespace AdventOfCode2022.Day8;

public class SolverPart2
{
    public int Execute(string[] lines)
    {
        var cols = lines[0].Length;
        var rows = lines.Length;

        var grid = new int[rows, cols];

        for (var r = 0; r < rows; r++)
        {
            for (var c = 0; c < cols; c++)
            {
                var line = lines[r];
                grid[r, c] = int.Parse(line[c].ToString());
            }
        }

        var highestScore = 0;

        for (var r = 0; r < rows; r++)
        {
            for (var c = 0; c < cols; c++)
            {
                var ls = 0;
                var rs = 0;
                var us = 0;
                var ds = 0;
                //left
                var left = new Stack<int>();
                for (var x = 0; x < c; x++)
                {
                    left.Push(grid[r, x]);
                }

                while (left.Count > 0)
                {
                    ls++;
                    if (left.Pop() >= grid[r, c])
                    {
                        break;
                    }
                }

                //right
                var right = new List<int>();
                for (var x = c + 1; x < cols; x++)
                {
                    right.Add(grid[r, x]);
                }

                foreach (var t in right)
                {
                    rs++;
                    if (t >= grid[r, c])
                    {
                        break;
                    }
                }

                //up
                var up = new Stack<int>();
                for (var y = 0; y < r; y++)
                {
                    up.Push(grid[y, c]);
                }

                while (up.Count > 0)
                {
                    us++;
                    if (up.Pop() >= grid[r, c])
                    {
                        break;
                    }
                }

                //down
                var down = new List<int>();
                for (var y = r + 1; y < rows; y++)
                {
                    down.Add(grid[y, c]);
                }

                foreach (var t in down)
                {
                    ds++;
                    if (t >= grid[r, c])
                    {
                        break;
                    }
                }

                var score = ls * rs * us * ds;
                highestScore = Math.Max(highestScore, score);
            }
        }
        return highestScore;
    }
}