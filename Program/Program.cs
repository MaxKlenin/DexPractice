using IEnumerableIEnumeratorLibrary;
using OOPLibrary.TortoiseType;
using IComparableLibrary.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                    "\n 3: IComparableLibrary");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowOOP();
                        break;
                    case "2":
                        ShowIEnumerableIEnumerator();
                        break;
                    case "3":
                        ShowIComparableLibrary();
                        break;
                    default:
                        key = false;
                        break;
                }
            }
            
        }

        static void ShowOOP()
        {
            Console.WriteLine("***Tortoise***");
            var defaultTortoise = new DefaultTortoise("DefaultTortoise", "Обычное", "Обычный");
            var commodoreTortoise = new CommodoreTortoise("CommodoreTortoise", "Укреплённое", "Металический", " 10 lvl");
            var admiralTortoise = new AdmiralTortoise("AdmiralTortoise", "Бионическое", "Титановый", " 40 lvl", "12 lvl", "10 lvl");
            
            var turtles = new BaseTortoise[] { defaultTortoise, commodoreTortoise, admiralTortoise };
            foreach (var tortoise in turtles)
            {
                tortoise.ShowInfo();
            }
        }
        
        static void ShowIEnumerableIEnumerator()
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

        static void ShowIComparableLibrary()
        {

            ArrayList rectangles = new ArrayList();
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int x = rnd.Next(1, 20);
                int y = rnd.Next(1, 20);
                rectangles.Add(new Rectangle(x,y));
            }

            Console.WriteLine(" Cписок квадрагов: ");
            foreach (var item in rectangles)
            {
                Console.WriteLine(item.ToString());
            }

            rectangles.Sort();

            Console.WriteLine("\n Отсортированный список квадрагов: ");

            foreach (var circle in rectangles)
            {
                Console.WriteLine(circle.ToString());
            }

            Console.ReadLine();
        }
    }
}
