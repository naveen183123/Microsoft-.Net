using System;
struct Coordinate
{
    public int x { get; set; }
    public int y { get; set; }
    public void display()
    {
        this.x = x;
        this.y = y;
    }
    public static void Main(String[] args)
    {
        int num = 23;
        Coordinate c1 = new Coordinate();
        //Boxing  
        object obj = num;
        //UnBoxing
        int i = (int)obj;
        Console.WriteLine("Value of object is " + obj);
        Console.WriteLine("Value of I is " + i);
        c1.display();
        Console.WriteLine(c1.x);
        Console.WriteLine(c1.y);
        Console.ReadLine();
    }
}