using System;
struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
}
class Structure
{
    public static void Main(string[] args)
    {
        Books book1;
        Books book2;
        Console.WriteLine("Enter the book1 title");
        book1.title = Console.ReadLine();
        Console.WriteLine("Enter the book1 author");
        book1.author = Console.ReadLine();
        Console.WriteLine("Enter the book1 subject");
        book1.subject = Console.ReadLine();
        Console.WriteLine("Enter the book1 id");

        try
        {
            book1.book_id = Convert.ToInt32(Console.ReadLine());

        }
        catch (FormatException e)
        {
            Console.WriteLine("Please Enter Only Integer Values");
        }
        finally
        {
            Environment.Exit(0);
        }
        Console.WriteLine("         ");
        Console.WriteLine("Printing the book1 Details");
        Console.WriteLine("book1 title : {0}", book1.title);
        Console.WriteLine("book1 author : {0}", book1.author);
        Console.WriteLine("book1 subject : {0}", book1.subject);

        Console.WriteLine("      ");
        Console.WriteLine("Enter the book2 title");
        book2.title = Console.ReadLine();
        Console.WriteLine("Enter the book2 author");
        book2.author = Console.ReadLine();
        Console.WriteLine("Enter the book2 subject");
        book2.subject = Console.ReadLine();
        Console.WriteLine("Enter the book2 id");
        try
        {
            book2.book_id = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please Enter Only Integer Values");
        }
        Console.WriteLine("         ");
        Console.WriteLine("Printing the book2 Details");
        Console.WriteLine("book2 title : {0}", book2.title);
        Console.WriteLine("book2 author : {0}", book2.author);
        Console.WriteLine("book2 subject : {0}", book2.subject);
    }
}