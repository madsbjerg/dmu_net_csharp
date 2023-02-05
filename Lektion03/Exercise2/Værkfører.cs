using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_6
{
    internal class Værkfører : Mekaniker
    {
        public int _udnaevnelse;
        public double _tillaeg;

        public Værkfører(CprNr cpr, string medarbejdernr, int udnaevnelse, double tillaeg, int svendeproeve, double timeloen, string navn, string adresse)
            :base(cpr, medarbejdernr, svendeproeve, timeloen, navn, adresse)
        {
            _udnaevnelse = udnaevnelse;
            _tillaeg = tillaeg;
        }


        public override string ToString()
        {
            return base.ToString() + $"\nUdnævnelses år: {_udnaevnelse}";
        }
        public int Udnaevnelse { get { return _udnaevnelse;} set { _udnaevnelse = value; } }
        public double Tillaeg { get { return _tillaeg; } set { _tillaeg = value; } }

        public override double BeregnUgeLoen()
        {
            return TimerPerUge * (Timeloen + Tillaeg);
        }
    }
}
