// See https://aka.ms/new-console-template for more information
using System;
using naveen;
using book;
class Program
{
    public static void Main(string[] args)
    {
        int num1,num2;
        Console.WriteLine("Enter First Number");
        num1 =Convert.ToInt32(Console.ReadLine());
        num2=num1;
        Console.WriteLine("num 1 is {0}. num2 is {1})",num1,num2);
        Console.WriteLine("Enter Second Number");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("num 1 is {0}. num2 is {1})", num1, num2);
        Console.ReadLine();
        Books book1;
        Books book2;
        Console.WriteLine("Enter Title for the Book1");
        book1.title = Console.ReadLine();
        Console.WriteLine("Enter Author Name for the Book1");
        book1.author = Console.ReadLine();
        Console.WriteLine("Enter the Subject name for the Book 1");
        book1.subject = Console.ReadLine();
        Console.WriteLine("Enter the Book id for the Book 1");
        book1.book_id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("   ");
        Console.WriteLine("Printing the Book1 Details");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Book 1 title : {0}",book1.title);
        Console.WriteLine("Book 1 author : {0}", book1.author);
        Console.WriteLine("Book 1 subject  : {0}", book1.subject);
        Console.WriteLine("Book 1 book id : {0}", book1.book_id);
        Console.WriteLine("----------------------------");
        Console.WriteLine("    ");
        Console.WriteLine("Enter Title for the Book2");
        book2.title = Console.ReadLine();
        Console.WriteLine("Enter the author for Book 2");
        book2.author = Console.ReadLine();
        Console.WriteLine("Enter the subject for Book 2");
        book2.subject = Console.ReadLine();
        Console.WriteLine("Enter the Book id for the Book 2");
        book2.book_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("   ");
        Console.WriteLine("Printing the Book1 Details");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Book 2 title : {0}", book2.title);
        Console.WriteLine("Book 2 author : {0}", book2.author);
        Console.WriteLine("Book 2 subject  : {0}", book2.subject);
        Console.WriteLine("Book 2 book id : {0}", book2.book_id);
        Console.WriteLine("----------------------------");
    }
}