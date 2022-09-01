using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Divide
    {
        public static void Main2()
        {
            int n1, n2;
            Console.WriteLine("Enter the two numbers: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            n2 = Convert.ToInt16(Console.ReadLine());

            int div = n1 / n2;
            Console.Write($"{n1}/{n2} is {div}");
        }
    }
}
