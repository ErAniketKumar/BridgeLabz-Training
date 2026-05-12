using System.Data.SqlTypes;
using System.Text;

public class BasicFileCrud
{
    public void FileCrud()
    {
        string RootPath = Directory.GetCurrentDirectory() + @"\FileAndDirectoryOnly";


        // File.WriteAllText(RootPath + @"\Hello.txt", "This is normal text content!");


        // string ss = File.ReadAllText(RootPath + @"\Hello.txt");
        // System.Console.WriteLine(ss);

        // string[] lines =
        // {
        //     "line 1",
        //     "line 2",
        //     "Line 3"
        // };

        // File.WriteAllLines(RootPath + @"\Hello.txt", lines);

        // string ss = File.ReadAllText(RootPath + @"\Hello.txt");
        // System.Console.WriteLine(ss);

        // string[] readline = File.ReadAllLines(RootPath + @"\Hello.txt");

        // foreach (var line in readline)
        // {
        //     System.Console.WriteLine(line[1]);
        // }

        // byte[] data = Encoding.UTF8.GetBytes(RootPath + @"\Hello.txt");

        // foreach (var d in data)
        // {
        //     System.Console.WriteLine(d);
        // }





        string[] lines =
        {
            "line 1",
            "line 2",
            "Line 3"
        };

        File.AppendAllLines(RootPath + @"\Hello.txt", lines);
        string ss = File.ReadAllText(RootPath + @"\Hello.txt");
        System.Console.WriteLine(ss);


        File.AppendAllText(RootPath + @"\Hello.txt", " This is new text for apppend!");
        string ss2 = File.ReadAllText(RootPath + @"\Hello.txt");
        System.Console.WriteLine(ss2);
        
    }

}