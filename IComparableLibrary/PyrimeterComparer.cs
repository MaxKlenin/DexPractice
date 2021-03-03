using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableLibrary.Figure
{
    class PyrimeterComparer : IComparer<BaseFigure>
    {
        public int Compare(BaseFigure first, BaseFigure second)
        {
            if (first != null && second != null)
            {
                double firstPyrimeter = first.GetPyrimeter();
                double secondPyrimeter = second.GetPyrimeter();
                if (secondPyrimeter > firstPyrimeter)
                {
                    return -1;
                }
                else if (secondPyrimeter == firstPyrimeter)
                {
                    return 0;
                }
                else return 1;
            }
            else
            {
                throw new ArgumentNullException("argument null");
            }
        }
    }
}
