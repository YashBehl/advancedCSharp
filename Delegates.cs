using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Delegate1(string msg);
    public delegate int Delegate2();
    public delegate T add<T>(T parameter1, T parameter2);
    class Program
    {
        static void Main(string[] args)
        {
            Delegate1 del = Class1.method1;
            del("class one");

            del = Class2.method1;
            del("class two");

            // by lambda expression
            del = (string msg1) => Console.WriteLine("via lambda expression: " + msg1);
            del("lambda");

            

            // delegate as parameter
            InvokeFunction(del);


            Delegate1 del1 = Class1.method1;
            Delegate1 del2 = Class2.method1;
            del = del1 + del2;
            del("classes one and two");

            Delegate2 del3 = Class1.method2;
            Delegate2 del4 = Class2.method2;
            Delegate2 del5 = del3 + del4;
            

            Console.WriteLine(del5());



            add<int> sum = sumOfTwoNumbers;
            Console.WriteLine(sum(100, 50));

            add<string> con = concatOfTwoStrings;
            Console.WriteLine(con("ab", "cd"));



            // func delegate
            Func<int, int, int> addNumbers = sumOfTwoNumbers;
            Console.WriteLine(addNumbers(20, -10));


            Func<string, string, string> concatStrings = concatOfTwoStrings;
            Console.WriteLine(concatStrings("xyz", "XYZ"));


            Func<int> getRandomNumber = delegate ()
            {
                Random ran = new Random();
                return ran.Next(50, 100);
            };
            Console.WriteLine(getRandomNumber());

            Console.ReadKey();


            //multicast delegate
            
            

        }

        static void InvokeFunction(Delegate1 delg)
        {
            delg("via invoking");
        }

        static int sumOfTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        static string concatOfTwoStrings(string s1, string s2)
        {
            return s1 + s2;
        }



    }
}
