using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    //public delegate void Warning();
    internal class PowerPlant
    {
        private Random _rand = new Random();
        private int _temp = 0;

        public delegate void Warning();

        private Warning _warning;
        public void SetWarning(Warning wa)
        {
            _warning = new Warning(wa);
        }
        public void AddWarning(Warning wa)
        {
            _warning += new Warning(wa);
        }

        public void HeatUp()
        {
            _temp = _rand.Next(100);
            if(_temp > 50)
            {
                _warning.Invoke();
            }
        }

        public int Temperature { get { return _temp; } }
    }
}
