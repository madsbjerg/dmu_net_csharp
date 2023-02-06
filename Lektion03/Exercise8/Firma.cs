using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise8
{
    internal class Firma : IHarAdresse
    {
        private Adresse _adresse;
        private string _navn;

        public Firma(string navn, Adresse adresse)
        {
            _adresse = adresse;
            _navn = navn;
        }

        public override string ToString()
        {
            return $"Firmanavn: {_navn} \nAdresse: {_adresse.ToString()}";
        }

        public Adresse Adresse { get { return _adresse; } set { _adresse = value; } }
    }
}
