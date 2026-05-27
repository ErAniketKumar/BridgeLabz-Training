public class MixedOpr
{
    public void PlayFile()
    {
        string FilePath = Directory.GetCurrentDirectory() + @"\FileSystem\C\temp.csv";
        string DirePath = Directory.GetCurrentDirectory() + @"\FileSystem\C";

        // File.WriteAllText(FilePath, "");

        // string[] employee =
        // {
        //     "Id, Name,Age",
        //     "1, Aniket, 22",
        //     "2, Kumar, 19",
        //     "3, Abhishek, 17",
        //     "4, Sonu, 16",
        //     "5, Ram, 18"
        // };

        // File.WriteAllLines(FilePath, employee);

        string[] lines = File.ReadAllLines(FilePath);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(",");

            int age = int.Parse(line[2]);
            if (age >= 18)
            {
                System.Console.WriteLine(line[0] + " " + line[2]);
            }
        }
    }

}