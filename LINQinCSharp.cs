using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Candidate> candidateList = new List<Candidate>()
            {
                new Candidate(1, "Yash", 25, "C sharp"),
                new Candidate(2, "Aryan", 21, "Java"),
                new Candidate(3, "Sahil", 26, "Python"),
                new Candidate(4, "Manvir", 20, "Python"),
                new Candidate(5, "Kunal", 25, "C++")
            };


            // using query syntax
            
            var linqQuery1 = from c in candidateList
                             where c.candidateName.Contains('n')
                             select c.candidateName;

            foreach(var x in linqQuery1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // using method syntax
            
            var linqMethod1 = candidateList.Where(c => c.candidateAge == 25).ToList();

            foreach (var x in linqMethod1)
            {
                Console.Write(x.candidateName + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            // orderby
            
            var linqMethod2 = candidateList.OrderBy(c => c.candidateAge);

            foreach (var x in linqMethod2)
            {
                Console.WriteLine(x.candidateName + " " + x.candidateAge);
            }
            Console.WriteLine();

            //orderby and thenby
            
            var linqMethod3 = candidateList.OrderBy(c => c.candidateAge).ThenBy(c => c.candidateName);

            foreach (var x in linqMethod3)
            {
                Console.WriteLine(x.candidateName + " " + x.candidateAge);
            }
            Console.WriteLine();


            // aggregate functions

            
            var averageAge = candidateList.Average(c => c.candidateAge);
            Console.WriteLine(averageAge);
            
            var maximumAge = candidateList.Max(c => c.candidateAge);
            Console.WriteLine(maximumAge);
            
            var minimumAge = candidateList.Min(c => c.candidateAge);
            Console.WriteLine(minimumAge);
            
            var sumOfAges = candidateList.Sum(c => c.candidateAge);
            Console.WriteLine(sumOfAges);

            Console.WriteLine();
            Console.WriteLine();


            // skip, take, skipwhile, takewhile
            
            var linqMethod4 = candidateList.Skip(2);
            foreach(var x in linqMethod4)
            {
                Console.WriteLine(x.candidateID + " " + x.candidateName + " " + x.candidateAge + " " + x.candidateField);
            }
            Console.WriteLine();
            Console.WriteLine();

            
            var linqMethod5 = candidateList.Take(3);
            foreach (var x in linqMethod5)
            {
                Console.WriteLine(x.candidateID + " " + x.candidateName + " " + x.candidateAge + " " + x.candidateField);
            }
            Console.WriteLine();
            Console.WriteLine();

            
            var linqMethod6 = candidateList.SkipWhile(c => c.candidateAge > 20);
            foreach (var x in linqMethod6)
            {
                Console.WriteLine(x.candidateID + " " + x.candidateName + " " + x.candidateAge + " " + x.candidateField);
            }
            Console.WriteLine();
            Console.WriteLine();

            var linqMethod7 = candidateList.TakeWhile(c => c.candidateAge > 20);
            foreach (var x in linqMethod7)
            {
                Console.WriteLine(x.candidateID + " " + x.candidateName + " " + x.candidateAge + " " + x.candidateField);
            }
            Console.WriteLine();
            Console.WriteLine();


            // firstOrDefault, lastOrDefault
            var firstCandidateOfEvenAge = candidateList.FirstOrDefault(c => c.candidateAge % 2 == 0);
            Console.WriteLine(firstCandidateOfEvenAge.candidateID + " " + firstCandidateOfEvenAge.candidateName + " " + firstCandidateOfEvenAge.candidateAge + " " + firstCandidateOfEvenAge.candidateField);
            var lastCandidateOfEvenAge = candidateList.LastOrDefault(c => c.candidateAge % 2 == 0);
            Console.WriteLine(lastCandidateOfEvenAge.candidateID + " " + lastCandidateOfEvenAge.candidateName + " " + lastCandidateOfEvenAge.candidateAge + " " + lastCandidateOfEvenAge.candidateField);

            Console.ReadKey();
        }
    }
}
