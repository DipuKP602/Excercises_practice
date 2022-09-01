using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises22
{
    public class Number
    {
        private int n1;

        public void GenerateTable()
        {
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine($"{n1} x {i} = {n1*i}");
            }
        }
        public Number()
        {
            Console.WriteLine("Enter the number: ");
            n1 = Convert.ToInt16(Console.ReadLine());
        }
    }

    internal class MulTable
    {
        public static void Main1()
        {
            Number n = new Number();
            n.GenerateTable();
        }
    }
}
