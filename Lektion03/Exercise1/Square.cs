using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Square : Shape
    {
        private double _width;
        private double _height;

        public Square(double width, double height, double x, double y) : base(x, y)
        {
            _width = width;
            _height = height;
        } 

        public double Width { get { return _width; } set { _width = value; } }

        public double Height { get { return _height;} set { _height = value; } }

        public override double GetArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return $"Type: Square, Width: {_width}, Height: {_height}, Position: {this.X}, {this.Y}";
        }
    }
}
