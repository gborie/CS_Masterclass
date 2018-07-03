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
            string myname = "Guillaume";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
        
    }
}
