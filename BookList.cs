

namespace ConsoleApp33
{
    internal class BookList
    {
        public string Name { get; set; }
        public int Employees { get; set; }
        public BookList(string name, int employees)
        {
            Name = name;
            Employees = employees;
        }
        public static BookList operator +(BookList journal, int employees)
        {
            journal.Employees += employees;
            return journal;
        }
        public static BookList operator -(BookList journal, int employees)
        {
            journal.Employees -= employees;
            return journal;
        }
        public static bool operator ==(BookList j1, BookList j2)
        {
            return j1.Employees == j2.Employees;
        }
        public static bool operator !=(BookList j1, BookList j2)
        {
            return j1.Employees != j2.Employees;
        }
        public static bool operator <(BookList j1, BookList j2)
        {
            return j1.Employees < j2.Employees;
        }
        public static bool operator >(BookList j1, BookList j2)
        {
            return j1.Employees > j2.Employees;
        }
    }
}
