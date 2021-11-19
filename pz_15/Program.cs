using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = File.ReadAllLines(@"C:\Users\Samsung\Desktop\new_file.txt").Length;
            Console.WriteLine(count);


            var words = File.ReadAllText(@"C:\Users\Samsung\Desktop\new_file.txt")
            .Split(" ,.!?';:\"\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Where(x => !x.Any(Char.IsDigit));

            Console.WriteLine(words.Count());
            Console.ReadLine();

        }
    }
}
