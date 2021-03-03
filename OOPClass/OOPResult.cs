using OOPLibrary.TortoiseType;

namespace OOPLibrary
{
    public static class OOPResult
    {
        public static void ShowOOP()
        {
            DefaultTortoise defaultTortoise = new DefaultTortoise("DefaultTortoise", "Обычное", "Обычный");
            CommodoreTortoise commodoreTortoise = new CommodoreTortoise("CommodoreTortoise", "Укреплённое", "Металический", " 10 lvl");
            AdmiralTortoise admiralTortoise = new AdmiralTortoise("AdmiralTortoise", "Бионическое", "Титановый", " 40 lvl", "12 lvl", "10 lvl");
            BaseTortoise[] turtles = new BaseTortoise[] { defaultTortoise, commodoreTortoise, admiralTortoise };

            foreach (var tortoise in turtles)
            {
                tortoise.ShowInfo();
            }
        }
    }
}
