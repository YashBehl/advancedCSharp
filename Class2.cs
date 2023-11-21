using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Class2
    {
        public static void method1(string message)
        {
            Console.WriteLine("method 1 of class 2 called");
            Console.WriteLine(message);
        }

        public static int method2()
        {
            return 100;
        }
    }
}
