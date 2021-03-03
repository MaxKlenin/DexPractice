using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IQueryableLibrary
{
    class IQueryable
    {
        static class IQueryableProgram
        {
            private static Doge[] dogs;
            static string[] dogeNames = { "Акита-ину", "Аляскинский Маламут", "Американская Акита", "Бигль",
            "Бладхаунд", "Бобтейл", "Боксер", "Босерон",
            "Немецкая овчарка", "Немецкий дог", "Ньюфаундленд"};

            public enum DogeEnum
            {
                Name, Number, Time, IsAvailable
            }

            static DateTime RandomDay(Random gen)
            {
                DateTime start = new DateTime(1995, 1, 1);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(gen.Next(range));
            }

            public static bool NextBoolean(Random random)
            {
                return random.Next() > (Int32.MaxValue / 2);
            }

            static void CreateDoge()
            {
                var rand = new Random();
                dogs = new Doge[100];
                for (int i = 0; i < 100; i++)
                {
                    int rndIndex = rand.Next(dogeNames.Length);
                    int rndNumber = rand.Next(0, 100);
                    dogs[i] = new Doge(dogeNames[rndIndex], rndNumber, RandomDay(rand), NextBoolean(rand));
                    rand.Next(0, 100);
                }
            }

            static void ShowDoge(IEnumerable<Doge> doges, DogeEnum type)
            {
                foreach (var item in doges)
                {
                    switch (type)
                    {
                        case DogeEnum.Name:
                            Console.WriteLine(item.Name);
                            break;
                        case DogeEnum.Number:
                            Console.WriteLine(item.Count);
                            break;
                        case DogeEnum.Time:
                            Console.WriteLine(item.Time);
                            break;
                        default:
                            Console.WriteLine(item.IsAvailable);
                            break;
                    }
                }
            }

            static void FirstDemo()
            {
                var numberDemo = dogs.Where(p => p.Count % 2 == 0).OrderBy(p => p.Count);
                ShowDoge(numberDemo, DogeEnum.Number);
            }

            static void SecondDemo()
            {
                var nameDemo = dogs.GroupBy(p => p.Name.Length).Select(g => new { Length = g.Key, Words = g });
                foreach (var item in nameDemo)
                {
                    Console.WriteLine("Brands with length " + item.Words.Key + ":");
                    foreach (var word in item.Words)
                        Console.WriteLine(word.Name);

                }
            }

          /*  static void ThirdDemo()
            {
                String toReturn = dogs.All(p => ((DateTimeOffset)p.Time).ToUnixTimeSeconds() > 1614000000)
                    ? "Все даты позднее, чем " + UnixTimeStampToDateTime(1614000000)
                    : dogs.Any(p => ((DateTimeOffset)p.Time).ToUnixTimeSeconds() > 1614000000)
                        ? "Есть даты не позднее, чем " + UnixTimeStampToDateTime(1614000000)
                        : "Нет ни одной даты позднее, чем " + UnixTimeStampToDateTime(1614000000);
                Console.WriteLine(toReturn);
            }*/

            public static void RunProgram()
            {
                CreateDoge();
                FirstDemo();
                SecondDemo();
                //ThirdDemo();

                var isAvailableDemo = dogs.Where(p => p.IsAvailable).GroupBy(p => p.Name)
                    .Select(g => new { Name = g.Key, productsWithCurrentName = g });
                List<int> sums = new List<int>();
                foreach (var item in isAvailableDemo)
                {
                    int checkSum = item.productsWithCurrentName.Sum(p => p.Count);
                    sums.Add(checkSum);
                }

                Console.WriteLine("Максимальное количество доступного товара одного бренда: " + sums.Max());
                Console.WriteLine("Минимальное количество доступного товара одного бренда: " + sums.Min());

            }

            
        }
    }
}
