using System;

namespace IQueryableLibrary
{

    public class Doge
    {
        public String Name { get; set; }
        public int Weight { get; set; }
        public DateTime Time { get; set; }
        public bool IsAvailable { get; set; }

        public Doge(String name, int weight, DateTime time, bool isAvailable)
        {
            Name = name;
            Weight = weight;
            Time = time;
            IsAvailable = isAvailable;
        }
    }
}
