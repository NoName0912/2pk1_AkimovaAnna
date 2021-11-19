using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Samsung\Desktop\new_file.txt";
            string AllText;

            using (FileStream file = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(file))
                AllText = reader.ReadToEnd();

            Console.Write("Введите подстроку: ");
            string subString = Console.ReadLine();
            Console.WriteLine();

            string[] lines = AllText.Split('\n');

            foreach (string line in lines)
            {
                if (line.Contains(subString))
                    Console.WriteLine(line);
            }
        }
    }
}
