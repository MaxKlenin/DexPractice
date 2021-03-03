using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableLibrary.Figure
{
    class Triangle : BaseFigure
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        public Triangle(double x, double y, double z)
        {
            if (x > 0 && y > 0 && z > 0)
            {
                if (x + y > z && y + z > x && x + z > y)
                {
                    _x = x;
                    _y = y;
                    _z = z;
                }
                else throw new ArgumentException("Такого треугольника не существует");
            }
            else throw new ArgumentException("У треугольника заданны стороны ранвые нулю");
        }

        public override double GetSquare()
        {
            double p = (_x + _y + _z) / 2;
            return Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z));
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
