using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableLibrary.Figure
{
    public class Rectangle : IComparable
    {
        private readonly double _x;
        private readonly double _y;

        public Rectangle(double x, double y)
        {        
          _x = x;
          _y = y;   
        }

        public double GetSquare()
        {
            return _x * _y;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Rectangle otherRectangle = obj as Rectangle;
            if (otherRectangle != null)
                return otherRectangle.GetSquare().CompareTo(this.GetSquare());
            else
                throw new ArgumentException("Объект не является квадратом");
        }

        public override string ToString()
        {
            return "Квадрат со сторонами " + _x + " и "+ _y +" имеет площадь " + Math.Round(this.GetSquare(), 2);
        }
    }
}
