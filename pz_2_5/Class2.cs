using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_5
{
    class Class2
    {
        internal class NegativeFN : FactionalNumber
        {
            int capacity = 4;
            public override void GetNumber()
            {
                string mask = "";
                for (int i = 0; i < capacity; i++)
                    mask += "0";

                Console.WriteLine($"{sign}{dividend.ToString(mask)}/{divider.ToString(mask)}");
            }

            public NegativeFN(char a)
            {
                Sign = a;
                Dividend = 50;
                Divider = 7;
            }

            public NegativeFN(double x, double n)
            {
                sign = '-';
                Dividend = x;
                Divider = n;
            }
        }


    }
}
