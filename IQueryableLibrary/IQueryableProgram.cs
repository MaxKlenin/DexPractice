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

        static void WhereSampling()
        {
            Console.WriteLine("***(Where) Клички собак начаниются на букву Б ***");
            var selectedDogeName = dogs.Where(d => d.Name.ToUpper().StartsWith("Б")).OrderBy(d => d.Name);
            foreach (var item in selectedDogeName)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void GroupBySampling()
        {
            Console.WriteLine("***(GroupBy) Кол-во собак каждой породы: ***");
            var dogeGroups = dogs.GroupBy(d => d.Name).Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var group in dogeGroups)
                Console.WriteLine($"{group.Name}: {group.Count}");
        }

        static void AnyAllSampling()
        {
            Console.WriteLine("***(AnyAll) Выборки по возрасту***");
            var dogeSampling = dogs.All(d => d.Time.Year < 2019);

            if (dogeSampling)
            {
                Console.WriteLine("Все собаки родились до 2019 года");
            }
            else
            {
                Console.WriteLine("Не все собаки родились до 2019 года");
            }

            dogeSampling = dogs.Any(d => d.Time.Year == 2020);

            if (dogeSampling)
            {
                Console.WriteLine("Хотя бы одна собака родилась в 2020 году");
            }
            else
            {
                Console.WriteLine("В 2020 году собаки не родились");
            }

        }

        static void MinMaxSumSamling()
        {
        }

        public static void IQueryableRun()
        {
            Generate();
            foreach (var doge in dogs)
            {
                Console.WriteLine($"Порода:{doge.Name} Вес:{doge.Weight}" +
                    $"\nДата :{doge.Time.ToShortDateString()} Привита:{doge.IsAvailable}\n");
            }
            WhereSampling();
            GroupBySampling();
            AnyAllSampling();
            MinMaxSumSamling();
        }
    }
}