namespace InterfaceDemo
{
    public interface Area
    {
        void area(double a, double b);
    }
    class Rectangle : Area
    {
        public void area(double a, double b)
        {
            double areaRectangle;
            areaRectangle = a * b;
            Console.WriteLine("the area of rectangle is :" + areaRectangle);
        }
    }
    class Circle : Area
    {
        static double PI = 3.14;
        public void area(double a, double b)
        {
            double areaCircle;
            areaCircle = PI * a * a;
            Console.WriteLine("the area of Circle is :" + areaCircle);
        }
    }
    class Interface
    {
        static void Main(string[] args)
        {
            Area a = new Rectangle();
            a.area(5, 6);
            a = new Circle();
            a.area(7, 0);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}