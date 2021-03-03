﻿using IEnumerableIEnumeratorLibrary;
using OOPLibrary;
using IComparableLibrary;
using System;
using SpeedBoxingUnboxingLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = true;
            while (key)
            {
                Console.WriteLine(" 1: OOPLibrary \n 2: ShowIEnumerableIEnumeratorLibrary" +
                    "\n 3: IComparableLibrary \n 4: IQueryableLibrary");

                switch (Console.ReadLine())
                {
                    case "1":
                        OOPResult.ShowOOP();
                        break;
                    case "2":
                        IEnumeratorResult.ShowIEnumerableIEnumerator();
                        break;
                    case "3":
                        IComparableResult.ShowIComporable();
                        break;
                    default:
                        key = false;
                        break;
                    case "4":
                        
                        break;
                }

            } 
        
        }

        private static void ShowIEnumerableIEnumerator()
        {
            Fruit[] fruits = {new Fruit("Яблоко", 15), new Fruit("Груша", 5),
                new Fruit("Ананас", 16), new Fruit("Апельсин", 3)};

            Basket basket = new Basket(fruits);
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var enumerator = basket.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void ShowIComparableLibrary()
        {
           
        }

        private static void ShowIQuerable()
        {
        }
    }
}
