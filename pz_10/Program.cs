using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {


            int[][] Arr = new int[10][];
            Arr[0] = new int[3];
            Arr[1] = new int[4];
            Arr[2] = new int[5];
            Arr[3] = new int[6];
            Arr[4] = new int[7];
            Arr[5] = new int[8];
            Arr[6] = new int[9];
            Arr[7] = new int[10];
            Arr[8] = new int[3];
            Arr[9] = new int[4];


            Random r = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Arr[i][j] = r.Next(3, 10);
                }
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            int[] Arr2 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Arr2[0] = (int)Arr[0][2];
            Arr2[1] = (int)Arr[1][3];
            Arr2[2] = (int)Arr[2][4];
            Arr2[3] = (int)Arr[3][5];
            Arr2[4] = (int)Arr[4][6];
            Arr2[5] = (int)Arr[5][7];
            Arr2[6] = (int)Arr[6][8];
            Arr2[7] = (int)Arr[7][9];
            Arr2[8] = (int)Arr[8][2];
            Arr2[9] = (int)Arr[9][3];
            for (int i = 0; i < Arr2.Length; i++)
            {
                Console.WriteLine(Arr2[i]);
            }
            Console.ReadLine();

            int max;
            for (int i = 0; i < 10; i++)
            {
                max = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (Arr[i][j] > max)
                    {
                        max = Arr[i][j];
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(max);
            }

            Console.ReadLine();

            int[] maxNums = new int[Arr.Length]; 

            for (int i = 0; i < maxNums.Length; i++)
            {
                int max1 = Arr[i][0];
                for (int k = 0; k < Arr[i].Length; k++)
                {
                    if (Arr[i][k] > max1)
                        max1 = Arr[i][k];
                }
                maxNums[i] = max1;
            }

            for (int i = 0; i < Arr.Length; i++) 
            {
                Arr[i][Array.IndexOf(Arr[i], maxNums[i])] = Arr[i][0];
                Arr[i][0] = maxNums[i];
            }

            Console.WriteLine("\nОбновлённый массив:");
            foreach (int[] nums in Arr)
            {
                foreach (int num in nums)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}
