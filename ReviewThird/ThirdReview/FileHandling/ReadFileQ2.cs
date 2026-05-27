public class ReadFileQ2
{
    public void ReadFileFun()
    {
        try
        {
            string RootPath = Directory.GetCurrentDirectory() + @"\FileDataOnly";

            System.Console.WriteLine("root path: " + RootPath);

            // File.Create(RootPath + @"\info.txt");

            using (StreamReader sr = new StreamReader(RootPath + @"\info.textt"))
            {
                string line1 = sr.ReadLine();
                System.Console.WriteLine(line1);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}