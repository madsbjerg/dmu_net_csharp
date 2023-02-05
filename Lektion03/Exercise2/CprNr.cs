using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_6
{
    internal class CprNr
    {
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        public CprNr(string birthDate, string seqNumber) 
        {
            BirthDate = birthDate;
            SequenceNumber = seqNumber;
        }

        public override string ToString()
        {
            return BirthDate + SequenceNumber;
        }

    }
}
