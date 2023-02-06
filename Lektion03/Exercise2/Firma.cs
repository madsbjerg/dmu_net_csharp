using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise2_6
{
    internal class Firma : IHarAdresse
    {
        private string _adresse;

        public Firma(string adresse)
        {
            _adresse = adresse;
        }

        public string Adresse { get { return _adresse; } set { _adresse = value; } }
    }
}
