using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableLibrary.Figure
{
    class Circle : BaseFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetSquare()
        {
            return Math.Pow(_radius, 2)*Math.PI;
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
