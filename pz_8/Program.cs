using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}:\t");

                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                numbers[i] = n;
            }

            foreach (int n in numbers)
            {
                total += n;
            }

            Console.WriteLine($"Сумма {total}");
            Console.ReadKey();
        }
    }
}
