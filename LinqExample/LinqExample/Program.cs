using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqExample
{
    class Program
    {
        static void Main(String[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            var QuerySyntax = from obj in list
                              where obj > 5
                              select obj;
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}