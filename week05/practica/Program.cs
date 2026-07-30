using System;
namespace lybrary_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetTitle("The Great Gatsby");
            book1.SetAuthor("F. Scott Fitzgerald");

            console.WriteLine(book1.GetBookInfo());
        }
    }
}