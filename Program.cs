namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magaz = new Magazine();
            magaz.Add("1991");
            magaz.Add("Medium");
            magaz += "Fahrenheit 350";
            magaz -= "Medium";
            magaz.Show(magaz);

            Shop shop = new Shop("Name1", 3.5);
            shop += 4.5;
            shop -= 2;
            Console.WriteLine($"{shop.Name} , {shop.Area}");

            BookList bookList = new BookList("Name1", 4);
            bookList += 2;
            bookList -= 3;
            Console.WriteLine($"{bookList.Name} - {bookList.Employees}");
        }
    }
}
