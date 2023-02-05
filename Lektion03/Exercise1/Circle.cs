using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Circle : Shape
    {
        private double _radius;
        public Circle(double x, double y, double radius) : base(x,y)
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Type: Circle, Radius: {_radius}, Position: {this.X}, {this.Y}";
        }

        public override double GetArea()
        {
            return Math.PI * (_radius * _radius);
        }

        public double Radius { get { return _radius; } set { _radius = value; } }
    }
}
