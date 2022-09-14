using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Aggregate 
{
    class Program
    {
        static void Main(string[] args)
        {  
            int[] array = new int[] { 11, 34, 23, 43, 85, 63, 57, 88, 79 };
            int minimum= array.Min();
            Console.WriteLine($"The Minimum Number in the Given Array is :{minimum}");
            int maximum = array.Max();
            Console.WriteLine($"The Maximum Number in the Given Array is :{maximum}");
            int sum=array.Sum();
            Console.WriteLine($"The Sum of all Elements in the Array is :{sum}");
            int count=array.Count();
            Console.WriteLine($"The Total Number of Elements in an Array is :{count}");
            int agg=array.Aggregate((a,b)=>a+b);
            Console.WriteLine($"Aggregate Sum of the array is :{agg}");
            Console.ReadLine(); 
        }
    }
}