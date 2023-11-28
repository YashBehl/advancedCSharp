using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    class Candidate
    {
        public int candidateID { get; set; }
        public string candidateName { get; set; }
        public int candidateAge { get; set; }
        public string candidateField { get; set; }

        public Candidate(int id, string name, int age, string field)
        {
            this.candidateID = id;
            this.candidateName = name;
            this.candidateAge = age;
            this.candidateField = field;
        }
    }
}
