using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    class CandidateComparer : IEqualityComparer<Candidate>
    {
        public bool Equals(Candidate c1, Candidate c2)
        {
            if ((c1.candidateID == c2.candidateID) && (c1.candidateName.ToLower() == c2.candidateName.ToLower()))
                return true;
            return false;
        }
        public int GetHashCode(Candidate obj)
        {
            return obj.candidateID.GetHashCode();
        }
    }
}
