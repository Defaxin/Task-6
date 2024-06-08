

namespace ConsoleApp33
{
    internal class Shop
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public Shop(string name, double area)
        {
            Name = name;
            Area = area;
        }
        public static Shop operator +(Shop store, double area)
        {
            store.Area += area;
            return store;
        }
        public static Shop operator -(Shop store, double area)
        {
            store.Area -= area;
            return store;
        }
        public static bool operator ==(Shop s1, Shop s2)
        {
            return s1.Area == s2.Area;
        }
        public static bool operator !=(Shop s1, Shop s2)
        {
            return s1.Area != s2.Area;
        }
        public static bool operator <(Shop s1, Shop s2)
        {
            return s1.Area < s2.Area;
        }
        public static bool operator >(Shop s1, Shop s2)
        {
            return s1.Area > s2.Area;
        }
    }
}
