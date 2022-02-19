using System;

namespace ConsoleApp1
{
    public class FactionalNumber
    {
        public char sign;
        public int dividend;
        public int divider;

        static int CounterPlus;
        static int CounterMinus;

        public double Dividend
        {
            get { return dividend; }
            set
            {
                if (value.GetTypeCode() == TypeCode.Double & (value % 2 == 0 || value % 3 == 0 || value % 5 == 0 || value % 7 == 0))
                {
                    dividend = Convert.ToInt32(value);


                }
                else
                    Console.WriteLine("Error.");




            }
        }

        public double Divider
        {
            get { return divider; }
            set
            {
                if (value.GetTypeCode() == TypeCode.Double & (value % 2 == 0 || value % 3 == 0 || value % 5 == 0 || value % 7 == 0) & value != 0)
                {
                    divider = Convert.ToInt32(value);


                }
                else
                    Console.WriteLine("Error.");


            }
        }
        public char Sign
        {
            set
            {
                if (value == '-')
                {
                    CounterMinus++;
                    sign = value;
                }
                else
                    CounterPlus++;
            }
        }

        public FactionalNumber(char a)
        {
            Sign = a;
            Dividend = 50;
            Divider = 7;

        }

        public FactionalNumber()
        {
            Console.WriteLine(CounterPlus);
            Console.WriteLine(CounterMinus);
        }

        public FactionalNumber(char a, double x, double n)
        {
            Sign = a;
            Dividend = x;
            Divider = n;
        }

        public void FactionalSymbol()
        {
            Console.WriteLine(CounterPlus);
            Console.WriteLine(CounterMinus);
        }


        public void GetNumber()
        {
            Console.WriteLine($"{sign}{dividend}/{divider}");
        }


    }
    public class Program
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
            }
            FactionalNumber factional2 = new FactionalNumber();


        }
    }
}

