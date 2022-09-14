using System;
namespace Delegates
{
    class DelegateProgram
    {
        public delegate void addnumbers(int x, int y);
      
        public delegate string SayHello(string name);
        public void addnum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayH(String n)
        {
            return "Hello" + n;
        }
       
        public static void Main(String[] args)
        {
            DelegateProgram program = new DelegateProgram();
            addnumbers a1 = new addnumbers(program.addnum);
            a1.Invoke(17000, 34000);
            SayHello sayHello = new SayHello(SayH);
            string sayHelloString = sayHello.Invoke("Naveen");
            Console.WriteLine(sayHelloString);
            Console.ReadLine();
        }
    }
}