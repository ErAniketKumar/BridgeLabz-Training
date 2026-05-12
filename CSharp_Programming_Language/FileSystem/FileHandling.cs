// // using System.IO.Stream;
// using System.IO;
// using System;
// using System.IO.Enumeration;
// using System.Text;
// using System.Collections.Generic;

// public class FileHandling
// {
//     public void FileHandlingOpr()
//     {
//         string filePath = Directory.GetCurrentDirectory() + @"\FileSystem\myFile.txt";

//         System.Console.WriteLine("file path" + filePath);
//         string destPath = Directory.GetCurrentDirectory() + @"\FileSystem\backup.txt";
//         // CHECK if file exists
//         if (File.Exists(filePath))
//         {
//             Console.WriteLine("File exists!");
//         }

//         // CREATE an empty file (overwrites if exists)
//         // Parameters: path, bufferSize (optional), fileOptions (optional)
//         using (FileStream fs = File.Create(filePath))
//         {
//             // Returns FileStream for writing
//             // Default buffer: 4096 bytes
//         }
//         // OR simpler:
//         File.Create(filePath).Close(); // Creates and immediately closes

//         string dest = Directory.GetCurrentDirectory() + @"\FileSystem\helloFile.txt";

//         // COPY file
//         // Parameters: sourceFileName, destFileName, overwrite (bool)
//         File.Copy(filePath, destPath, overwrite: true);
//         // overwrite: true = replace existing file; false = throw exception if exists


//         File.Move(filePath, dest);


//         // DELETE file
//         File.Delete(filePath);
//         // No exception if file doesn't exist - safe to call


//         // GET file attributes
//         FileAttributes attributes = File.GetAttributes(filePath);
//         Console.WriteLine($"ReadOnly: {attributes.HasFlag(FileAttributes.ReadOnly)}");
//         Console.WriteLine($"Hidden: {attributes.HasFlag(FileAttributes.Hidden)}");
//         Console.WriteLine($"System: {attributes.HasFlag(FileAttributes.System)}");

//         // SET file attributes
//         File.SetAttributes(filePath, FileAttributes.ReadOnly | FileAttributes.Hidden);
//         // Remove readonly:
//         File.SetAttributes(filePath, FileAttributes.Normal);



//         // FileInfo provides instance methods and properties
//         FileInfo fileInfo = new FileInfo(@"C:\Temp\data.txt");

//         // Properties
//         Console.WriteLine($"Full Name: {fileInfo.FullName}");
//         Console.WriteLine($"Name: {fileInfo.Name}");
//         Console.WriteLine($"Extension: {fileInfo.Extension}");
//         Console.WriteLine($"Directory: {fileInfo.DirectoryName}");
//         Console.WriteLine($"Size: {fileInfo.Length} bytes"); // Throws if file doesn't exist
//         Console.WriteLine($"Created: {fileInfo.CreationTime}");
//         Console.WriteLine($"Modified: {fileInfo.LastWriteTime}");
//         Console.WriteLine($"Accessed: {fileInfo.LastAccessTime}");
//         Console.WriteLine($"Is ReadOnly: {fileInfo.IsReadOnly}");

//         // Methods
//         if (!fileInfo.Exists)
//         {
//             using (FileStream fs = fileInfo.Create())
//             {
//                 // Creates file and returns FileStream
//             }
//         }

//         fileInfo.CopyTo(@"C:\Temp\copy.txt", overwrite: true);
//         fileInfo.MoveTo(@"C:\Temp\moved.txt");
//         fileInfo.Delete();

//         // Refresh - updates file info from disk
//         fileInfo.Refresh();


//         string searchPath = @"C:\Temp";

//         // GET all files (returns string[])
//         string[] allFiles = Directory.GetFiles(searchPath);
//         foreach (string file in allFiles)
//         {
//             Console.WriteLine(Path.GetFileName(file));
//         }

//         // Get files with pattern
//         string[] txtFiles = Directory.GetFiles(searchPath, "*.txt");
//         string[] logFiles = Directory.GetFiles(searchPath, "*.log", SearchOption.AllDirectories);



//         string filePath2 = @"C:\Temp\sample.txt";

//         // === WRITING ===

//         // WriteAllText - creates/overwrites entire file with string
//         // Parameters: path, contents, encoding (optional)
//         File.WriteAllText(filePath2, "Hello World!\nSecond line");
//         File.WriteAllText(filePath2, "This overwrites everything", Encoding.UTF8);

//         // WriteAllLines - writes string array (each element = new line)
//         // Parameters: path, contents, encoding (optional)
//         string[] lines = { "Line 1", "Line 2", "Line 3" };
//         File.WriteAllLines(filePath2, lines);

//         // AppendAllText - adds to end of file
//         File.AppendAllText(filePath, "This is appended\n");

//         // AppendAllLines - appends string array
//         string[] newLines = { "Appended line 1", "Appended line 2" };
//         File.AppendAllLines(filePath, newLines);

//         // === READING ===

//         // ReadAllText - reads entire file as single string
//         string content = File.ReadAllText(filePath2);
//         Console.WriteLine(content);

//         // ReadAllLines - reads all lines into string array
//         string[] allLines = File.ReadAllLines(filePath2);
//         for (int i = 0; i < allLines.Length; i++)
//         {
//             Console.WriteLine($"Line {i}: {allLines[i]}");
//         }

//         // ReadAllBytes - reads as byte array (for binary files)
//         byte[] bytes = File.ReadAllBytes(filePath);



//         string filePath3 = @"C:\Temp\largefile.txt";

//         // METHOD 1: ReadLines (streaming - doesn't load all into memory)
//         IEnumerable<string> lines2 = File.ReadLines(filePath);
//         foreach (string line in lines2)
//         {
//             // Process each line immediately
//             Console.WriteLine(line);
//             // Memory usage stays constant regardless of file size
//         }

//         // METHOD 2: StreamReader (more control)
//         using (StreamReader reader = new StreamReader(filePath))
//         {
//             string line;
//             int lineNumber = 0;

//             while ((line = reader.ReadLine()) != null)
//             {
//                 lineNumber++;
//                 Console.WriteLine($"Line {lineNumber}: {line}");

//                 // Can break out early if needed
//                 if (lineNumber > 100) break;
//             }
//         }

//         // METHOD 3: Reading with specific encoding
//         using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8, detectEncodingFromByteOrderMarks: true))
//         {
//             string line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 Console.WriteLine(line);
//             }
//         }
//     }
// }