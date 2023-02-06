using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_6
{
    internal class MedarbejderCollection
    {
        private Dictionary<string, IHarAdresse> _dict;
        private int _size;

        public MedarbejderCollection() 
        {
            _dict = new Dictionary<string, IHarAdresse>();
            _size = 0;
        }

        public void Add(string adresse, IHarAdresse element)
        {
            _dict.Add(adresse, element);
            _size++;
        }

        public IHarAdresse Get(string adresse)
        {
            try
            {
                return _dict[adresse];
            }
            catch(KeyNotFoundException ex)
            {
                return null;
            }
        }

        public int Size()
        {
            return _size; 
        }
    }
}
