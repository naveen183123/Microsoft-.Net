using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Array_Assignment
{
    class SailsList
    {
        public static void Main(String[] args)
        {
        Initial:
            int MaxSize = 10;
            int[] array = new int[MaxSize];
            Console.WriteLine("    List Implementation using Arrays     ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Add Array");
            Console.WriteLine("4.Enumerable");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter Your Choice :(1 - 5 Only)");
            int choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch(choice)
                {
                    case 1:
                        Add();
                        goto Initial;
                        
                    case 2:
                        Delete();
                        goto Initial;
                    case 3:
                        AddArray();
                        goto Initial;
                    case 4:
                        Enumerate();
                        goto Initial;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter Only Between 1 to 5");
                        Console.WriteLine();
                        goto Initial; 
                }
            }while (choice < 5);
            void Add()
            {
                
                Console.WriteLine("Enter the Data to be Add :-");
                int data=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Position Where the Data Should be Added :-");
                int pos=Convert.ToInt32(Console.ReadLine());
                array[pos]=data;
                MaxSize++;
                Display(); 
            }
            void Delete()
            {
                Console.WriteLine("Enter the Position index for Deleting the Element :");
                int pos=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The Deleted Item in the Array is: {array[pos]}");
                array[pos]=0;
                MaxSize--;
                Display();
            }
            void AddArray()
            {
                Console.WriteLine("Enter the length of the Array to be Added :");
                int len = Convert.ToInt32(Console.ReadLine());
                int[] addarray=new int[len];
                Console.WriteLine("Enter the Array Elements");
                for(int i=0; i<len;i++)
                {
                    Console.WriteLine($"Enter the Element for array[{i}]:");
                    addarray[i]=Convert.ToInt32(Console.ReadLine());
                }
                int tempsize= MaxSize + addarray.Length;
                for(int i = MaxSize-1; i<tempsize; i++)
                {
                    int inc=0;
                    if(array[i]==0)
                    {
                        array[i]=addarray[inc];
                    }
                    inc++;
                }
                MaxSize = tempsize;
                Display();
            }
            void Enumerate()
            {
                IEnumerable<int> a = from k in array select k;
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }
            }
            void Display()
            {
                Console.WriteLine("Printing the Array ");
                foreach (int dis in array)
                {
                    Console.WriteLine(dis);
                }

            }
        }
    }
}