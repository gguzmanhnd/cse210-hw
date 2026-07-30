using System;
namespace library_demo
{
    class Program
    {
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("F. Scott Fitzgerald");
        book1.SetTitle("The Great Gatsby");
        

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Harper Lee");
        book2.SetTitle("To Kill a Mockingbird");
        book2.SetIllustrator("Gegz");
        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetIllustratedBookInfo());

        Book book3 = new PictureBook();
        Console.WriteLine(book3.GetBookInfo());

        Book book4 = new Book();
        Console.WriteLine(book4.GetBookInfo());
    }
    }
}