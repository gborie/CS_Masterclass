using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 35;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            float f1 = 3.5F;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum );
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.Read();
        }
        
    }
}
