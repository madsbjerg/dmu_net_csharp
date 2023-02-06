using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
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

        public override bool Equals(object? obj)
        {
            if (((CprNr)obj).GetHashCode() == this.GetHashCode()) return true;
            else return false;
        }

        //public override int GetHashCode()
        //{
        //    return BirthDate ^ SequenceNumber;
        //}
    }
}
