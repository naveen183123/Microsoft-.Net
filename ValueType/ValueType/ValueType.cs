using System;
namespace ValueTypes
{
    class Value
    {
        static void changevalue(int x)
        {
            x=200;
            Console.WriteLine(x);
        }
        public static void Main()
        {
            int i = 100;
            Console.WriteLine(i);
            changevalue(i);
            Console.WriteLine(i);
        }
    }
}