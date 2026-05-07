using System.IO;

using System.Text.Json;
using System.Text;


public class DirFileHandling
{
    public void DirFileOpr()
    {
        string RootPath = @"D:\BridgeLabz-Training\CSharp_Programming_Language\FileSystem";

        string[] dircs = Directory.GetDirectories(RootPath);

        System.Console.WriteLine(dircs);
    }
}