using IComparableLibrary.Figure;
using System;

namespace IComparableLibrary
{
    public static class IComparableResult
    {
        private static BaseFigure[] _fArray;
        public static void Generate()
        {
            var rand = new Random();
            _fArray = new BaseFigure[10];
            int i = 0;
            while(i < _fArray.Length)
            { 
                switch (i % 3)
                {
                    case 0:
                        _fArray[i] = new Circle(rand.Next(1, 10));
                        break;
                    case 1:
                        _fArray[i] = new Rectangle(rand.Next(1, 5), rand.Next(1, 5));
                        break;
                    case 2:
                        try
                        {
                            _fArray[i] = new Triangle(rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11));
                        }
                        catch (Exception)
                        {
                            i--;
                        }
                        break;
                }
                i++;
            }
        }

        public static void ShowIComporable()
        {
            Generate();
            Console.WriteLine("Список площадей: ");
            foreach (var item in _fArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }

            Console.WriteLine();
            Array.Sort(_fArray, new SquareComparer());
            Console.WriteLine("Отсортированный : ");
            foreach (var item in _fArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }

            Generate();
            Console.WriteLine("\nСписок Пириметров: ");
            foreach (var item in _fArray)
            {
                Console.WriteLine(item + " с пириметром: " + item.GetPyrimeter());
            }
            Console.WriteLine();
            Array.Sort(_fArray, new PyrimeterComparer());
            Console.WriteLine("Отсортированный : ");
            foreach (var item in _fArray)
            {
                Console.WriteLine(item + " с пириметром: " + item.GetPyrimeter());
            }
        }
    }
}
