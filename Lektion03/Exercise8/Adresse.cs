using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Adresse
    {
        private string _vejnavn;
        private string _husNummer;
        private string _postNummer;

        public Adresse(string vejnavn, string husNummer, string postNummer)
        {
            _vejnavn = vejnavn;
            _husNummer = husNummer;
            _postNummer = postNummer;
        }

        public override string ToString()
        {
            return $"{_vejnavn}, {_husNummer}, {_postNummer}";
        }

        public string Vejnavn { get { return _vejnavn; } }
        public string HusNummer { get { return _husNummer; } }
        public string PostNummer { get { return _postNummer; } }

    }
}
