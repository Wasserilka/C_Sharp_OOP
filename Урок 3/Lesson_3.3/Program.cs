using System;
using System.IO;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathFrom = "text.txt";
            var pathTo = "result.txt";

            File.WriteAllText(pathTo, "");

            using (StreamReader reader = new StreamReader(pathFrom))
            {
                var line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    SearchMail(ref line);
                    File.AppendAllText(pathTo, $"{line}\n");
                } 
            }
        }

        static void SearchMail(ref string str)
        {
            str = str.Split("&")[1].Trim();
        }
    }
}
