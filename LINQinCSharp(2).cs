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
                new Candidate(4, "Manvir", 21, "Python"),
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


            // firstOrDefault, lastOrDefault, singleOrDefault
            var firstCandidateOfEvenAge = candidateList.FirstOrDefault(c => c.candidateAge % 2 == 0);
            Console.WriteLine(firstCandidateOfEvenAge.candidateID + " " + firstCandidateOfEvenAge.candidateName + " " + firstCandidateOfEvenAge.candidateAge + " " + firstCandidateOfEvenAge.candidateField);
            var lastCandidateOfEvenAge = candidateList.LastOrDefault(c => c.candidateAge % 2 == 0);
            Console.WriteLine(lastCandidateOfEvenAge.candidateID + " " + lastCandidateOfEvenAge.candidateName + " " + lastCandidateOfEvenAge.candidateAge + " " + lastCandidateOfEvenAge.candidateField);
            //var singleCandidateOfEvenAge = candidateList.SingleOrDefault(c => c.candidateAge % 2 == 0);
            //Console.WriteLine(singleCandidateOfEvenAge.candidateID + " " + singleCandidateOfEvenAge.candidateName + " " + singleCandidateOfEvenAge.candidateAge + " " + singleCandidateOfEvenAge.candidateField);

            Console.WriteLine();
            Console.WriteLine();

            IList<CandidateDetails> candidateDetailsList = new List<CandidateDetails>()
            {
                new CandidateDetails(1, "Noida"),
                new CandidateDetails(2, "Faridabad"),
                new CandidateDetails(4, "Noida"),
                new CandidateDetails(6, "Delhi")
            };

            // Join

            var join = candidateList.Join(
                        candidateDetailsList,
                        candidate => candidate.candidateID,
                        candidateDetails => candidateDetails.candidateID,
                        (candidate, candidateDetails) => new
                        {
                            CandidateID = candidate.candidateID,
                            CandidateName = candidate.candidateName,
                            CandidateAddress = candidateDetails.candidateAddress
                        });

            foreach(var x in join)
            {
                Console.WriteLine(x.CandidateID + " " + x.CandidateName + " " + x.CandidateAddress);
            }
            Console.WriteLine();
            Console.WriteLine();


            // select 
            var selectedResult = candidateList.Select(c => new { Name = c.candidateName, Field = c.candidateField});
            foreach (var x in selectedResult)
            {
                Console.WriteLine(x.Name + " " + x.Field);
            }
            Console.WriteLine();
            Console.WriteLine();


            // check all
            bool areAllStudentsUnder30 = candidateList.All(c => c.candidateAge < 30);
            Console.WriteLine(areAllStudentsUnder30);
            // check any
            bool isAnyStudentAbove30 = candidateList.Any(c => c.candidateAge > 30);
            Console.WriteLine(isAnyStudentAbove30);
            Console.WriteLine();
            Console.WriteLine();



            IList<Candidate> candidateList2 = new List<Candidate>()
            { 
                new Candidate(3, "Sahil", 26, "Python"),
                new Candidate(5, "Kunal", 25, "C++"),
                new Candidate(7, "Aman", 22, "C Sharp"),
                new Candidate(7, "Aman", 22, "C Sharp")
            };


            // except
            var candidatesInList1not2 = candidateList.Except(candidateList2, new CandidateComparer());
            foreach(var x in candidatesInList1not2)
            {
                Console.WriteLine(x.candidateName);
            }
            Console.WriteLine();
            Console.WriteLine();



            // intersect
            var commonOfList1and2 = candidateList.Intersect(candidateList2, new CandidateComparer());
            foreach (var x in commonOfList1and2)
            {
                Console.WriteLine(x.candidateName);
            }
            Console.WriteLine();
            Console.WriteLine();


            // union
            var unionOfList1and2 = candidateList.Union(candidateList2, new CandidateComparer());
            foreach (var x in unionOfList1and2)
            {
                Console.WriteLine(x.candidateName);
            }
            Console.WriteLine();
            Console.WriteLine();

            // distinct
            var distinctCandidatesInList2 = candidateList2.Distinct(new CandidateComparer());
            foreach (var x in distinctCandidatesInList2)
            {
                Console.WriteLine(x.candidateName);
            }
            Console.WriteLine();
            Console.WriteLine();




            // groupby
            var groupedByAge = candidateList.GroupBy(c => c.candidateAge);
            foreach (var x in groupedByAge)
            {
                Console.WriteLine("Age: " + x.Key);

                foreach(var y in x)
                {
                    Console.WriteLine(y.candidateName + " " + y.candidateAge);
                }
            }
            Console.WriteLine();
            Console.WriteLine();



            // tolookup
            var toLookUpByAge = candidateList.ToLookup(c => c.candidateAge);
            foreach (var x in toLookUpByAge)
            {
                Console.WriteLine("Age: " + x.Key);

                foreach (var y in x)
                {
                    Console.WriteLine(y.candidateName + " " + y.candidateAge);
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            // elementAtOrDefault
            Console.WriteLine("Name of first candidate: " + candidateList.ElementAtOrDefault(0).candidateName);


            Console.ReadKey();
        }
    }
}
