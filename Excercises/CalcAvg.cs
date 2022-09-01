using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises22
{

    public class Numbers
    {
        int n1, n2, n3, n4;

        public int avg()
        {
            return (n1 + n2 + n3 + n4)/4;
        }
        public Numbers()
        {
            Console.WriteLine("Enter value of n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n3: ");
            n3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of n4: ");
            n4 = Convert.ToInt16(Console.ReadLine());
        }
    }
    public class CalcAvg
    {
        public static void Main1()
        {
            Numbers n = new Numbers();
            Console.WriteLine($"Average is { n.avg()}");
        }
    }
}
