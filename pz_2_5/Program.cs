﻿using System;

namespace pz_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите знак + или - ");
                char sign1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите первое значение: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе значение: ");
                double b = Convert.ToDouble(Console.ReadLine());

                FactionalNumber factional1 = new FactionalNumber(sign1, a, b);
                factional1.GetNumber();
                Console.WriteLine("");
                var negFN = new NegativeFN(a, b);
                negFN.GetNumber();
            }
            
        }
    }
}
