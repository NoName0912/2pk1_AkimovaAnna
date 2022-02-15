using System;

namespace ConsoleApp3
{
    public class FactionalNumber
    {
        public char Sign;
        public float Dividend;
        public float Divider;
        public FactionalNumber(char a, double x, double n)
        {
            Sign = a;
            Dividend = (float)x;
            Divider = (float)n;
            Console.WriteLine("Объект создан.");
        }
        public FactionalNumber(double x, double n)
        {
            Dividend = (float)x;
            Divider = (float)n;
            Console.WriteLine("Объект создан.");
        }

        public void GetNumber()
        {
            float b = Dividend / Divider;

            Console.WriteLine($"{Sign}{Dividend}/{Divider}\nРезультат: {Sign}{b}");
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите знак + или -");
            char sign1 = Convert.ToChar(Console.ReadLine());
            FactionalNumber factional1 = new FactionalNumber(sign1, 5, 7);
            factional1.GetNumber();
            FactionalNumber factional9 = new FactionalNumber(5, 7);
            factional9.GetNumber();
            FactionalNumber factional2 = new FactionalNumber(5, -7);
            factional2.GetNumber();
            FactionalNumber factional10 = new FactionalNumber(-5, 7);
            factional10.GetNumber();
            FactionalNumber factional6 = new FactionalNumber(-5, -7);
            factional6.GetNumber();

            Console.WriteLine("Введите знак + или -");
            char sign2 = Convert.ToChar(Console.ReadLine());
            FactionalNumber factional3 = new FactionalNumber(sign2, 22.4, 2);
            factional3.GetNumber();
            FactionalNumber factional12 = new FactionalNumber(22.4, 2);
            factional12.GetNumber();
            FactionalNumber factional13 = new FactionalNumber(22.4, -2);
            factional13.GetNumber();
            FactionalNumber factional14 = new FactionalNumber(-22.4, 2);
            factional14.GetNumber();
            FactionalNumber factional8 = new FactionalNumber(-22.4, -2);
            factional8.GetNumber();

            Console.WriteLine("Введите знак + или -");
            char sign3 = Convert.ToChar(Console.ReadLine());
            FactionalNumber factional4 = new FactionalNumber(sign3, 22.4, 11.2);
            factional4.GetNumber();
            FactionalNumber factional11 = new FactionalNumber(22.4, 11.2);
            factional11.GetNumber();
            FactionalNumber factional5 = new FactionalNumber(-22.4, 11.2);
            factional5.GetNumber();
            FactionalNumber factional19 = new FactionalNumber(22.4, -11.2);
            factional19.GetNumber();
            FactionalNumber factional7 = new FactionalNumber(-22.4, -11.2);
            factional7.GetNumber();

            Console.WriteLine("Введите знак + или -");
            char sign4 = Convert.ToChar(Console.ReadLine());
            FactionalNumber factional15 = new FactionalNumber(sign4, 23, 2.5);
            factional15.GetNumber();
            FactionalNumber factional20 = new FactionalNumber(23, 2.5);
            factional20.GetNumber();
            FactionalNumber factional16 = new FactionalNumber(23, -2.5);
            factional16.GetNumber();
            FactionalNumber factional17 = new FactionalNumber(-23, 2.5);
            factional17.GetNumber();
            FactionalNumber factional18 = new FactionalNumber(-23, -2.5);
            factional18.GetNumber();
        }
    }
}
