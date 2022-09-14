using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Linq1
{
    class Program
    {
        static void Main(String[] args)
        {
            IEnumerable<Employee> developers = new Employee[] {new Employee { Id=1,Name="Naveen"},new Employee { Id=2,Name="Sails"} };
            IEnumerable<Employee> sales = new List<Employee>() { new Employee { Id=3,Name="Ram"} };
            Console.WriteLine(sales.Count());
            IEnumerator<Employee> rr= developers.GetEnumerator();
            Console.WriteLine(developers.Count());
       
            while(rr.MoveNext())
            {
                Console.WriteLine(rr.Current.Name);
            }
            foreach (var person in sales)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}