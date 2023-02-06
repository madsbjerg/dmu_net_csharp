using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Synsfører : Mekaniker
    {
        private int _antalSyn;

        public Synsfører(CprNr cpr, string medarbejdernr, int antalSyn, int svendeproeve,  string navn, Adresse adresse) : 
            base(cpr, medarbejdernr, svendeproeve, 0, navn, adresse)
        {
            _antalSyn = antalSyn;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int AntalSyn { get { return _antalSyn; } set { _antalSyn = value; } }

        public override double BeregnUgeLoen()
        {
            return AntalSyn * 220;
        }
    }
}
