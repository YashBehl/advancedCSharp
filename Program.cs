using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace November16th
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr1 = new int[5] {1,2,3,4,5};
            arr1[5] = 7;
            for (int i=0; i<arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            

            int[,] arr2 = new int[2, 2] { { 1,2}, { 2,2} };
            for (int i = 0; i < 2; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[][] arr3 = new int[4][];
            arr3[0] = new int[3] { 3, 2, 1 };*/


            ArrayList arr4 = new ArrayList();

            arr4.Add(15);
            arr4.Add("abcd");
            arr4.Add(21.4);
            arr4.Add(DateTime.Now);

            foreach(object obj in arr4)
            {
                Console.WriteLine(obj.ToString());
            }



            Hashtable hash = new Hashtable();

            hash.Add(15, "abcd");
            hash.Add(21, "efgh");
            hash.Add(5, 6.5);
            hash.Add(2, "xyz");

            foreach (DictionaryEntry h in hash)
            {
                Console.WriteLine(h.Key + " " + h.Value);
            }


            Queue q = new Queue();

            q.Enqueue(15);
            q.Enqueue("abcd");
            q.Enqueue(21.4);
            q.Enqueue(DateTime.Now);

            foreach (object obj in q)
            {
                Console.WriteLine(obj);
            }

            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("after dequeuing");
            foreach (object obj in q)
            {
                Console.WriteLine(obj);
            }


            List<int> lst = new List<int>();

            lst.Add(15);
            lst.Add(6);
            lst.Add(21);
            lst.Add(-5);

            foreach (object obj in lst)
            {
                Console.WriteLine(obj);
            }


            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(15, "fifteen");
            dict.Add(6, "six");
            dict.Add(21, "twenty one");
            dict.Add(-2, "minus two");

            foreach (KeyValuePair<int, string> obj in dict)
            {
                Console.WriteLine(obj.Key + " " + obj.Value);
            }


            Queue<string> q1 = new Queue<string>();

            q1.Enqueue("one");
            q1.Enqueue("abcd");
            q1.Enqueue("two");
            q1.Enqueue("xyz");

            foreach (object obj in q1)
            {
                Console.WriteLine(obj);
            }

            q1.Dequeue();
            q1.Dequeue();
            Console.WriteLine("after dequeuing");
            foreach (object obj in q1)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
