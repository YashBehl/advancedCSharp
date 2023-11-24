using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23rdNovember
{
    class Program
    {
        static int multiplicationOfTwoNumbers(int x, int y)
        {
            return x * y;
        }

        static void printName(string s)
        {
            Console.WriteLine(s);
        }

        static bool isHundred(int x)
        {
            return x == 100;
        }
        static void Main(string[] args)
        {
            // Q1. Try catch example
            /*int div = 0;
            
            try
            {
                float res = 100 / div;
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }*/



            //Q4. Try to use Func, Action and Predicate any program. 
            Func<int, int, int> mul = multiplicationOfTwoNumbers;

            int result = mul(10, 5);

            Console.WriteLine(result);



            Action<string> printYourName  = printName;
            printYourName("Yash");


            Predicate<int> pred = isHundred;

            bool output = pred(100);

            Console.WriteLine(output);



            Console.ReadKey();
        }
    }
}
