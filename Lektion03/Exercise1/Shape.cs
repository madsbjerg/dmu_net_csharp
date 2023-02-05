using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal abstract class Shape
    {
        private double _x, _y;

        public Shape()
        {
            _x = 1;
            _y = 1;
        }

        public Shape (double x, double y)
        {
            _x = x;
            _y = y;
        }

        public abstract double GetArea();
        public abstract override string ToString();
        public double X {
            get { return _x; } 
            set {
                _x = value;
            } 
        }

        public double Y { 
            get { return _y; } 
            set { _y = value; } 
        }
    }
}
