using System;
namespace Assignment
{
    class assignment1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Entered Array Length is {n}");
            int[] NUMBERS = new int[n];
            Console.WriteLine($"You Have to Enter {n} Elements");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please Enter Value {i}:");
                NUMBERS[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You Entered Elements are: (Before Getting Even and Odd Elements)");
            foreach(int swap in NUMBERS)
            {
                Console.WriteLine(swap);
            }
            void getEven()
            {
                int[] even=new int[n];
                for(int i = 0;i < NUMBERS.Length;i++)
                {
                    if(NUMBERS[i]%2==0)
                    {
                        even[i] = NUMBERS[i];
                    }
                }
                foreach(int naveen in even)
                {
                    if(naveen==0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(naveen);
                    }
                }
            }
            void getOdd()
            {
                int[] odd=new int[n];
                for (int i = 0; i < NUMBERS.Length; i++)
                {
                    if ( NUMBERS[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        odd[i] = NUMBERS[i];
                    }
                }
                foreach(int sails in odd)
                {
                    if(sails==0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(sails);
                    }
                   
                }
            }
            Console.WriteLine("Enter your Choice 'E' or 'O' ");
            char c=Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case 'E':
                    Console.WriteLine("Printing Even Numbers: ");
                    getEven();
                    break;
                case 'O':
                    Console.WriteLine("Printing Odd Numbers: ");
                    getOdd();
                    break;
                default:
                    Console.WriteLine("Don't Enter Remaining Characters Please Enter Either E or O ");
                    break;
            }
        }
          
    }
}