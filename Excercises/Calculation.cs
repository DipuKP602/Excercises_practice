using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Calculation
    {
        public static void Evaluate(double s)
        {
            Console.WriteLine(s);
        }
        public static void Main1()
        {
            double e1 = -1 + 4 * 6;
            double e2 = (35 + 5) % 7;
            double e3 = 14 + -4 * 6 / 11;
            double e4 = 2 + 15 / 6 * 1 - 7 % 2;
            Evaluate(e1);
            Evaluate(e2);
            Evaluate(e3);
            Evaluate(e4);
        }
    }
}
