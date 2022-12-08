using System.Text.RegularExpressions;
using Xunit.Abstractions;
namespace AdventOfCode2022.Day7;

public class Folder
{
    public Folder(Folder parent)
    {
        Parent = parent;
    }
    
    private Dictionary<string, int> Files = new ();
    public Dictionary<string, Folder> Folders = new ();
    public Folder Parent;
    
    public int TotalSize()
    {
        return Folders.Values.Sum(f => f.TotalSize()) + Files.Sum(f => f.Value);
    }

    public void AddFolder(string folderName)
    {
        if (Folders.ContainsKey(folderName))
            return;
        var newFolder = new Folder(this);
        Folders.Add(folderName, newFolder);
    }

    public void AddFile(string fileName, int size)
    {
        if(Files.ContainsKey(fileName)) return;
        Files.Add(fileName, size);
    }

    public Folder GetSubFolderCreateIfNotExist(string name)
    {
        if (Folders.TryGetValue(name, out var folder))
            return folder;
        AddFolder(name);
        return GetSubFolderCreateIfNotExist(name);
    }

    public IEnumerable<Folder> AllFolders()
    {
        return Folders.Values.Union(Folders.Values.SelectMany(f => f.AllFolders()));
    }
}

public class SolverPart1
{
    private readonly ITestOutputHelper _output;
    private readonly Regex _fileRegex = new (@"([0-9]*) (.*)");

    public SolverPart1(ITestOutputHelper output)
    {
        _output = output;
    }
    
    Folder root = new (null);
    Folder current;

    public int Execute(string[] inputs)
    {
        current = root;
        foreach (var line in inputs)
        {
            ProcessLine(line);
        }
        //root.Print("", _output);
        int SIZE = 100000;
        return root.AllFolders().Select(f => f.TotalSize()).Where(size => size <= SIZE).Sum();
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