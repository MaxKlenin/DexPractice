using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IQueryableLibrary
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

      


    }
}

