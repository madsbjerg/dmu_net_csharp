using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class MedarbejderCollection
    {
        private Dictionary<Adresse, IHarAdresse> _dict;
        private int _size;

        public MedarbejderCollection() 
        {
            _dict = new Dictionary<Adresse, IHarAdresse>();
            _size = 0;
        }

        public void Add(Adresse adresse, IHarAdresse element)
        {
            _dict.Add(adresse, element);
            _size++;
        }

        public IHarAdresse Get(Adresse adresse)
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
