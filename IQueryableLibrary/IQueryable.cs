using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableLibrary
{
    public static class IQueryableProgram
    {
        private static Doge[] dogs;
        static string[] dogeNames = { "Акита-ину", "Аляскинский Маламут", "Американская Акита",
            "Бигль", "Бладхаунд", "Бобтейл", "Боксер", "Босерон",
            "Немецкая овчарка", "Немецкий дог", "Ньюфаундленд"};

        static DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public static bool NextBoolean(Random random)
        {
            return random.Next() > (Int32.MaxValue / 2);
        }

        static void Generate()
        {
            var rand = new Random();
            dogs = new Doge[100];
            for (int i = 0; i < 100; i++)
            {
                int rndIndex = rand.Next(dogeNames.Length);
                int rndWeight = rand.Next(1, 51);
                int day = rand.Next(1, 29);
                int month = rand.Next(1, 13);
                int year = rand.Next(2015, 2021);
                dogs[i] = new Doge(dogeNames[rndIndex], rndWeight,
                    new DateTime(year, month, day), NextBoolean(rand));
            }
        }

        static void Print(IEnumerable<Doge> doges, DogeEnum itemToPrint)
        {
            foreach (var item in doges)
            {
                switch (itemToPrint)
                {
                    case DogeEnum.Name:
                        Console.WriteLine(item.Name);
                        break;
                    case DogeEnum.Number:
                        Console.WriteLine(item.Weight);
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
            Console.WriteLine("*** Клички собак начаниются на букву Б ***");
            var selectedDogeName = dogs.Where(d => d.Name.ToUpper().StartsWith("Б")).OrderBy(d => d.Name);
            foreach (var item in selectedDogeName)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void SecondDemo()
        {
            Console.WriteLine("*** Кол-во собак каждой породы: ***");
            var dogeGroups = dogs.GroupBy(d => d.Name).Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var group in dogeGroups)
                Console.WriteLine($"{group.Name}: {group.Count}");
        }

     /*   static void ThirdDemo()
        {
            String toReturn = dogs.All(p => ((DateTimeOffset)p.Time).ToUnixTimeSeconds() > 1614000000)
                ? "Все даты позднее, чем " + UnixTimeStampToDateTime(1614000000)
                : dogs.Any(p => ((DateTimeOffset)p.Time).ToUnixTimeSeconds() > 1614000000)
                    ? "Есть даты не позднее, чем " + UnixTimeStampToDateTime(1614000000)
                    : "Нет ни одной даты позднее, чем " + UnixTimeStampToDateTime(1614000000);
            Console.WriteLine(toReturn);
        }*/

        public static void IQueryableRun()
        {
           /*
             ThirdDemo();

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
             */
            Generate();

             foreach (var doge in dogs)
              {
                  Console.WriteLine($"Порода:{doge.Name} Вес:{doge.Weight}" +
                      $"\nДата :{doge.Time.ToShortDateString()} Привита:{doge.IsAvailable}\n");
              }
            
            FirstDemo();
             SecondDemo();
        }

        public enum DogeEnum
        {
            Name, Number, Time, IsAvailable
        }
    }
}