using System;
namespace MulticastDelegates
{
    public delegate void Rdelegate(double width, double height);
    class MDelegates
    {
        public void GetArea(double width, double Height)
        {
            Console.WriteLine(width*Height);
        }
        public void GetPerimeter(double width, double Height)
        {
            Console.WriteLine(2*(width+Height));
        }
        public static void Main(String[] args)
        {
            MDelegates md=new MDelegates();
            Rdelegate rd = md.GetArea;
            rd+=md.GetPerimeter;
            rd.Invoke(13.4, 54.2);
            Console.WriteLine();
            rd.Invoke(22.4, 65.43);
            Console.ReadLine();
        }
    }
}