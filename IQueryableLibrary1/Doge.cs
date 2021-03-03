using System;

namespace IQueryableLibrary
{

    public class Doge
    {
        public String Name { get; set; }
        public int Count { get; set; }
        public DateTime Time { get; set; }
        public bool IsAvailable { get; set; }

        public Doge(String name, int count, DateTime time, bool isAvailable)
        {
            Name = name;
            Count = count;
            Time = time;
            IsAvailable = isAvailable;
        }

    }

}
