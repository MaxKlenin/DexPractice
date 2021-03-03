using System;

namespace IComparableLibrary.Figure
{
    public abstract class BaseFigure : System.IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Figure does't exist");
            }
            else
            {
                if (obj is BaseFigure)
                {
                    double firstSquare = ((BaseFigure)obj).GetSquare();
                    double secondSquare = this.GetSquare();
                    if (secondSquare < firstSquare)
                    {
                        return -1;
                    }
                    else if (secondSquare == firstSquare)
                    {
                        return 0;
                    }
                    else return 1;
                }
                else throw new ArgumentException("Wrong argument");
            }
        }
        public abstract double GetSquare();
    }
}
