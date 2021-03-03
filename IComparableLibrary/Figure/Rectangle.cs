using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableLibrary.Figure
{
    class Rectangle : BaseFigure
    {
        private readonly double _x;
        private readonly double _y;

        public Rectangle(double x, double y)
        {        
          _x = x;
          _y = y;   
        }

        public override double GetSquare()
        {
            return _x * _y;
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
