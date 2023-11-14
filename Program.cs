using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    class Program
    {
        public struct Books
        {
            private string _title;
            private string _author;
            private string _subject;
            private int _bookId;


            public Books(string title, string author, string subject, int bookId)
            {
                _title = title;
                _author = author;
                _subject = subject;
                _bookId = bookId;
            }


            public void printDetails()
            {
                Console.WriteLine("Book id: " + _bookId + " ,Author: " + _author + " ,Subject: " + _subject + " ,title: " +  _title);
            }
        }
        static void Main(string[] args)
        {
            

            //Class1 cs = new Class1(25);
            //Console.WriteLine(Class1.readOnlyValue);
            //Console.WriteLine(cs.readOnlyValue);
            //Console.WriteLine(cs.readOnlyValue1);

            /*Logging logging = new Logging();
            logging.WriteLog("Message", Logging.LogTypes.Warnings);*/

            Books book1 = new Books("Programming in C#", "Arun Kumar", "Computer Science", 100);
            book1.printDetails();

            Console.ReadKey();
        }

    
    }
    
}

