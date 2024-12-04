using System
namespace library_demo
{
    class Program
    {
        static void Main(string[]args)
        {
            Book book1 = new Book();
            book1.SetAuthor('Joe')
            book1.SetTitle('Tim')
            Console.WriteLine(book1.GetBookInfo());
        }
    }
}