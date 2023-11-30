using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    class CandidateDetails
    {
        public int candidateID { get; set; }
        public string candidateAddress { get; set; }

        public CandidateDetails(int id, string address)
        {
            this.candidateID = id;
            this.candidateAddress = address;
        }
    }
}
