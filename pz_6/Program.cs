using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            while (i * i <= n)
            {
                Console.WriteLine((i * i++).ToString());
            }
        }
    }
}
