using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Numbers {
        private int n1;
        private int n2;

        public Numbers()
        {
            Console.WriteLine("Enter the numbers: ");
            this.n1 = Convert.ToInt16(Console.ReadLine());
            this.n2 = Convert.ToInt16(Console.ReadLine());
        }
        public void swap() {

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine($"After Swap\nn1: {n1}\nn2: {n2}");
        
        }
    }
    public class Swap
    {
        public static void Main1()
        {
            Numbers obj = new Numbers();
            obj.swap();
        }
    }
}
