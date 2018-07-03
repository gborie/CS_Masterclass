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
            //Implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;


            //Explicit conversion
            //cast double to int;

            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;

            //Type Conversion

            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();


            Console.WriteLine(myFloatString);
            Console.Read();
        }
        
    }
}
