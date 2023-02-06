using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal abstract class Medarbejder : IHarAdresse
    {
        private CprNr _cpr;
        private string _navn;
        private Adresse _adresse;
        private string _medarbejderNr;
        private const int _timerPrUge = 37;

        public Medarbejder(CprNr cpr, string medarabejderNr, string navn, Adresse adresse)
        {
            _cpr = cpr;
            _navn = navn;
            _adresse = adresse;
            _medarbejderNr = medarabejderNr;
        }

        public abstract double BeregnUgeLoen();

        public override string ToString()
        {
            return $"Navn: {Navn}\nAdresse: {Adresse.ToString()}\nMedarbejderNr: {MedarbejderNr}\nCPR: {_cpr.ToString()}\n";
        }

        public string Navn { get { return _navn; } set { _navn = value; } }
        public Adresse Adresse { get { return _adresse; } set { _adresse = value; } }

        public int TimerPerUge { get { return _timerPrUge; } }

        public string MedarbejderNr { get { return _medarbejderNr; } set { _medarbejderNr = value; } }

        public CprNr CPR { get { return _cpr; } set { _cpr = value; } }


    }
}
