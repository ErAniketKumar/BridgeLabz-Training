using System.IO;

using System.Text.Json;
using System.Text;
using System.Runtime.InteropServices;


public class DirectoryHandling
{
    public void DirFileOpr()
    {
        string RootPath = @"D:\BridgeLabz-Training\CSharp_Programming_Language\FileSystem";

        // string[] dircs = Directory.GetDirectories(RootPath);

        // foreach (string s in dircs)
        // {
        //     System.Console.WriteLine(s);
        // }

        // string[] alldir = Directory.GetDirectories(RootPath, "*", SearchOption.AllDirectories);


        // foreach (string s in alldir)
        // {
        //     System.Console.WriteLine(s);
        // }

        // System.Console.WriteLine("curr dir: ", Directory.GetCurrentDirectory());
        string currentDir = Directory.GetCurrentDirectory();
        Console.WriteLine($"Current Directory: {currentDir}");
        // Get directory information without checking existence
        DirectoryInfo dirInfo = new DirectoryInfo(currentDir);
        System.Console.WriteLine($"dir ingo {dirInfo}");
        Console.WriteLine($"Parent Directory: {dirInfo.Parent.FullName}");
        Console.WriteLine($"Root Directory: {dirInfo.Root.FullName}");
        Console.WriteLine($"Directory Exists: {dirInfo.Exists}");

        // Get system special directories
        // string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        // string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Console.WriteLine($"Desktop: {desktopPath}");
        // Console.WriteLine($"Documents: {documentsPath}");



        string testDir = @"C:\Temp\MyTestDirectory";

        // CREATE directory (with multiple levels automatically)
        // Parameters: path (string), directorySecurity (optional)
        Directory.CreateDirectory(testDir);
        // Returns DirectoryInfo object if successful
        // Creates all missing subdirectories in the path

        // CHECK if directory exists
        if (Directory.Exists(testDir))
        {
            Console.WriteLine("Directory exists!");
        }

        // GET all directories (with search patterns)
        // Parameters: path, searchPattern (optional), searchOption (optional)
        // string[] allDirs = Directory.GetDirectories(@"C:\Temp");
        // Returns string[] of full paths

        // Search with pattern and recursive option
        // string[] logDirs = Directory.GetDirectories(@"C:\Temp", "Log*", SearchOption.AllDirectories);
        // SearchOption.TopDirectoryOnly - only current directory (default)
        // SearchOption.AllDirectories - includes subdirectories recursively

        // GET all directories as DirectoryInfo objects (more properties)
        // DirectoryInfo[] dirInfos = new DirectoryInfo(@"C:\Temp").GetDirectories("*", SearchOption.AllDirectories);
        // foreach (DirectoryInfo dir in dirInfos)
        // {
        //     Console.WriteLine($"Name: {dir.Name}, Created: {dir.CreationTime}, Size: {GetDirectorySize(dir)}");
        // }

        // MOVE/RENAME directory
        // Parameters: sourceDirName, destDirName
        // Directory.Move(@"C:\Temp\OldName", @"C:\Temp\NewName");
        // Warning: Must be on same drive, dest cannot exist

        // DELETE directory
        // Parameter: path, recursive (bool) - optional, default false
        // Directory.Delete(@"C:\Temp\MyTestDirectory", recursive: true);
        // recursive: true = delete all contents including subdirectories
        // recursive: false = only delete empty directory (throws exception if not empty)

        // Get parent directory
        DirectoryInfo parent = Directory.GetParent(currentDir);
        Console.WriteLine($"Parent: {parent.FullName}");
        // Get logical drives
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        foreach (DriveInfo drive in allDrives)
        {
            Console.WriteLine($"Drive: {drive.Name}");
            Console.WriteLine($"  Type: {drive.DriveType}");
            Console.WriteLine($"  Format: {drive.DriveFormat}");
            Console.WriteLine($"  Total Size: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
            Console.WriteLine($"  Free Space: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
            Console.WriteLine($"  Ready: {drive.IsReady}");
        }



    }
}