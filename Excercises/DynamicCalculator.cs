using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises1
{

    public class Calculator
    {
        int n1, n2;


        public int add()
        {
            return n1 + n2;
        }

        public int sub()
        {
            return n1 - n2;
        }
        public int mul()
        {
            return n1 * n2;
        }

        public int div()
        {
            return n1 / n2;
        }

        public int mod()
        {
            return n1 % n2;
        }
        public Calculator()
        {
            Console.WriteLine("Enter value of n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

        }
    }
    public class DynamicCalculator
    {
        public static void Main1()
        {
            Calculator calc = new Calculator();
            Console.WriteLine("RESULTS");
            Console.WriteLine($"Add: {calc.add()}");
            Console.WriteLine($"Sub: {calc.sub()}");
            Console.WriteLine($"Mul: {calc.mul()}");
            Console.WriteLine($"Div: {calc.div()}");
            Console.WriteLine($"Mod: {calc.mod()}");
        }
    }
}
