using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int[,] A = new int[4, 5];
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    A[i, j] = r.Next(-99, 99);
                    Console.Write(A[i, j] + " ");

                }
                Console.WriteLine("");
            }

            Console.WriteLine("Максимальные элементы в каждом столце");
            
            for (int i = 0; i < A.GetLength(1); ++i)
            {
                int tempmax = int.MinValue;
                for (int j = 0; j < A.GetLength(0); ++j)
                {
                    if (A[j, i] > tempmax)
                    {
                        tempmax = A[j, i];
                    }
                }

                Console.WriteLine("В столбце номер {0} -> {1}", i, tempmax);

            }
            Console.ReadKey();
        }
    }
}
