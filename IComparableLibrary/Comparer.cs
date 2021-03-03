﻿using IComparableLibrary.Figure;
using System;
using System.Collections.Generic;

namespace IComparableLibrary
{
    public class Comparer : IComparer<BaseFigure>
    {

        public int Compare(BaseFigure first, BaseFigure second)
        {
            if (first != null && second != null)
            {
                double firstSquare = first.GetSquare();
                double secondSquare = second.GetSquare();
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
            else
            {
                throw new ArgumentNullException("argument null");
            }
        }
    }
}