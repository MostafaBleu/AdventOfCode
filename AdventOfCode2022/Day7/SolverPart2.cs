using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace AdventOfCode2022.Day7;

public class SolverPart2
{
    private readonly ITestOutputHelper _output;
    private readonly Regex _fileRegex = new (@"([0-9]*) (.*)");
        
    public SolverPart2(ITestOutputHelper output)
    {
        _output = output;
    }
    
    Folder root = new (null);
    Folder current = null;

    public int Execute(string[] inputs)
    {
        foreach (var line in inputs)
        {
            ProcessLine(line);
        }
        //root.Print("", _output);
        int targetDelete = 30000000 - (70000000 - root.TotalSize());
        int totalSize = root.AllFolders().Select(d => d.TotalSize()).Where(d => d >= targetDelete).OrderBy(d => d).FirstOrDefault();
        return totalSize ;
    }

    private void ProcessLine(string line)
    {
        if (line.StartsWith("$ cd /"))
        {
            current = root;
            return;
        }
        
        if (line.StartsWith("$ cd .."))
        {
            current = current.Parent;
            return;
        }
            
        if(line.StartsWith("$ ls"))
            return;
        
        if (line.StartsWith("$"))
        {
            var folderName = line.Substring(5);
            current = current.GetSubFolderCreateIfNotExist(folderName);
            return;
        }

        if (line.StartsWith("dir"))
        {
            var folderName = line.Substring(4);
            current.AddFolder(folderName);
            return;
        }
        
        var match = _fileRegex.Match(line);
        var size = int.Parse(match.Groups[1].Value);
        var fileName = match.Groups[2].Value;
        current.AddFile(fileName, size);
    }
}