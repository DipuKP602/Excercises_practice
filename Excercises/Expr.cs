using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises21
{
    public class Calculator
    {
        int n1, n2, n3;

        public void Evaluate()
        {
            Console.WriteLine($"Result of specified numbers {n1}, {n2} and {n3}, (x+y).z is {(n1+n2)*n3} and x.y + y.z is { n1 * n2 + n2 * n3 }");
        }
        public Calculator()
        {
            Console.WriteLine("Enter value of n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n3: ");
            n3 = Convert.ToInt16(Console.ReadLine());
        }
    }

    public class Expr
    {
        public static void Main() {
            Calculator calc = new Calculator();
            calc.Evaluate();
        }
    }
}
