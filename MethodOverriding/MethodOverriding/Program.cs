using System;
namespace Application
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animals makes a sound");
        }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine(" Cat Sounds Meow...!! Meow.....!!");
        }
    }

    class Monkey : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Monkey Sounds Kich...!!! Kich...!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal c1 = new Cat(); 
            Animal m1 = new Monkey();  
            a1.AnimalSound();
            c1.AnimalSound();
            m1.AnimalSound();
        }
    }
}