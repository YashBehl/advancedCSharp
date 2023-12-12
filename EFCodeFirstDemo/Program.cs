using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EFCodeFirstContext context = new EFCodeFirstContext())
            {
                var stud = new Student() { FirstName = "Pranaya", LastName = "Rout" };
                context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("Student Added");
                Console.ReadKey();
            }
        }
    }
}
