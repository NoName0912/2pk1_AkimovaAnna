using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, j;
            Console.WriteLine("Задание №1:\n");
            for (k = 0; k <= 100; k += 2)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
            Console.WriteLine("\nЗадание №2:\n");
            string[] a = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };
            for (i = 0; i <= 4; i++) Console.Write(a[i]);
            Console.ReadLine();
            Console.WriteLine("\nЗадание №3:\n");
            for (i = 0; i <= 4; i++)
            {
                for (k = 0; k <= 2; k++) Console.Write("#");
                Console.WriteLine("");
            }
            Console.ReadLine();
            Console.WriteLine("\nЗадание №4:\n");
            for (int u = 1; u <= 100; u++) if (u % 3 == 0) Console.Write(" " + u);
            Console.ReadLine();
            Console.WriteLine("\nЗадание №5:\n");
            i = 1;
            j = 40;
            for (; ; )
            {
                if (i != 10 && j != 10)
                {
                    i++;
                    j--;
                }
                else if (j != 10) j--;
                else break;
                Console.WriteLine(i + "," + j);
            }
        }
    }
}
