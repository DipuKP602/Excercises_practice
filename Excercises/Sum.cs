using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Sum
    {
        public static void Main1()
        {
            int n1, n2;
            Console.WriteLine("Enter the two numbers: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            n2 = Convert.ToInt16(Console.ReadLine());

            int sum = n1 + n2;
            Console.WriteLine($"Sum of {n1} and {n2} is {sum}");
        }
    }
}
