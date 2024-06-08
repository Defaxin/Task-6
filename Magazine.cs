

namespace ConsoleApp33
{
    internal class Magazine
    {
        public List<string> books = new List<string>();
        public void Add(string book)
        {
            books.Add(book);
        }
        public void Del(string book)
        {
            books.Remove(book);
        }
        public static Magazine operator +(Magazine bookList, string book)
        {
            bookList.Add(book);
            return bookList;
        }
        public static Magazine operator -(Magazine bookList, string book)
        {
            bookList.Del(book);
            return bookList;
        }
        public void Show(Magazine magazine)
        {
            for (int i = 0; i < magazine.books.Count; i++)
            {
                Console.WriteLine(magazine.books[i]);
            }
        }
    }
}
