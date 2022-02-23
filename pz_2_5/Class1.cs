using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_5
{
    internal class FactionalNumber
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
        public virtual char Sign// добавила virtual для возможности переопределения в производном классе
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


        public virtual void GetNumber()// добавила virtual для возможности переопределения в производном классе
        {
            Console.WriteLine($"{sign}{dividend}/{divider}");
        }
    }
}
