using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_6
{
    internal class Mekaniker : Medarbejder
    {
        private int _svendeproeve;
        private double _timeloen;

        public Mekaniker(CprNr cpr, string medarbejdernr, int svendeproeve, double timeloen, string navn, string adresse) : 
            base(cpr, medarbejdernr, navn, adresse)
        {
            _svendeproeve = svendeproeve;
            _timeloen = timeloen;
        }

        public override double BeregnUgeLoen()
        {
            return TimerPerUge * Timeloen;
        }

        public override string ToString()
        {
            return base.ToString() + $"Svendeproeve: {Svendeproeve}\nUgeløn: {BeregnUgeLoen()}";
        }

        public int Svendeproeve { get { return _svendeproeve;} set { _svendeproeve = value; } }
        public double Timeloen { get { return _timeloen; } set { _timeloen = value; } }

    }
}
