using System;
using System.IO;

namespace pz_17
{
    class Program
    {
        static char GetCharMaxEntries(char[] chars)
        {
            int maxCount = 1;
            char maxCh = chars[0];

            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                int count = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if (ch == chars[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxCh = ch;
                }
            }
            return maxCh;
        }
        static void Main(string[] args)
        {
            char[] array = new char[70];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(rnd.Next('a', 'a' + 42));
                Console.Write(array[ i ]);
            }
            Console.ReadKey(true);

            Console.ReadLine();

            char ch = GetCharMaxEntries(array);
            Console.WriteLine("Этот символ встречается наибольшее количество раз: ");
            Console.WriteLine(ch);
        }
    }
}
