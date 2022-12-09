namespace AdventOfCode2022.Day8;

public class SolverPart1
{
    public int Execute(string[] lines)
    {
        var cols = lines[0].Length + 2;
        var rows = lines.Length + 2;

        var grid = new int[rows, cols];

        for (var r = 0; r < rows; r++)
        {
            for (var c = 0; c < cols; c++)
            {
                if (r == 0 || r == rows - 1 || c == 0 || c == cols - 1)
                {
                    grid[r, c] = -1;
                }
                else
                {
                    var line = lines[r - 1];
                    grid[r, c] = int.Parse(line[c - 1].ToString());
                }
            }
        }

        var visible = 0;

        for (var r = 1; r < rows - 1; r++)
        {
            for (var c = 1; c < cols - 1; c++)
            {
                var hidden = true;

                //left
                var left = new List<int>();
                for (var x = 0; x < c && hidden; x++)
                {
                    left.Add(grid[r, x]);
                }

                if (left.All(t => t < grid[r, c]))
                {
                    visible++;
                    continue;
                }

                //right
                var right = new List<int>();
                for (var x = c + 1; x < cols && hidden; x++)
                {
                    right.Add(grid[r, x]);
                }

                if (right.All(t => t < grid[r, c]))
                {
                    visible++;
                    continue;
                }

                //up
                var up = new List<int>();
                for (var y = 0; y < r && hidden; y++)
                {
                    up.Add(grid[y, c]);
                }
        
                if (up.All(t => t < grid[r, c]))
                {
                    visible++;
                    continue;
                }

                //down
                var down = new List<int>();
                for (var y = r + 1; y < rows && hidden; y++)
                {
                    down.Add(grid[y, c]);
                }
        
                if (down.All(t => t < grid[r, c]))
                {
                    visible++;
                    continue;
                }
            }
        }
        return visible;
    }
}