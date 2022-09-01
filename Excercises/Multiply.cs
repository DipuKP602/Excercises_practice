using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Calculator
    {
        int n1, n2, n3;

        public int mul()
        {
            return n1 * n2 * n3;
        }
        public Calculator() {
            Console.WriteLine("Enter value of n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n3: ");
            n3 = Convert.ToInt16(Console.ReadLine());
        }
    }
    public class Multiply
    {
        public static void Mai1()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.mul());
        }
    }
}
