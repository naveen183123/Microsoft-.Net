using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task3
{
    class Program
    {
        static void Main()
        {
            IEnumerable<Student> students = new Student[]
            {
                new Student{Id = 1082, Name ="Naveen", Age =21,Gender="Male",place="Kadapa"},
                new Student{Id =1093, Name ="Sai",Age =22,Gender="Male",place ="Kadapa"},
                new Student{Id =1032,Name ="Abhi",Age=21,Gender="Male",place="Kadapa"},
                new Student{Id=1023,Name ="Priya",Age=22,Gender="Female",place="Nellore"},
                new Student{Id=1059,Name ="Keerthi",Age=21,Gender="Female",place="Chitoor"},
                new Student{Id=1238,Name ="Narendra",Age=21,Gender="Male",place="Kadapa"},
                new Student{Id=1039,Name ="Yuva",Age=22,Gender="Male",place="Kadapa"},
                new Student{Id=1101, Name ="Jyothsna",Age=22,Gender="Female",place="Kadapa"},
                new Student{Id=1053,Name="Vennala",Age=21,Gender="Female",place="Chitoor"},
                new Student{Id=1259,Name="Charitha",Age =22,Gender="Female",place="Kadapa"}
            };
            var re = from e in students
                     select e.Name;
            Console.WriteLine("Printing the Student Names");
            Console.WriteLine("--------------------------------");
            foreach(var proj in re)
            {
                Console.WriteLine("Student Name :{0}",proj);
            }
            var res = students.Select(a => new {ids=a.Id,names=a.Name,Ages=a.Age,Genders=a.Gender,places=a.place});
            Console.WriteLine("Printing the Whole Students Data ");
            Console.WriteLine("--------------------------------");
            foreach (var pro in res)
            {
                Console.WriteLine($"Student Id :{pro.ids} Student Name :{pro.names} Student Age :{pro.Ages} Student Gender :{pro.Genders} Student Place :{pro.places}");
            }
            Console.WriteLine("Printing the Names Start with S");
            Console.WriteLine("--------------------------------");
            foreach (var sss in students.Where(e=>e.Name.StartsWith("S")))
            {
                Console.WriteLine(sss.Name);
            }
            Console.WriteLine("Printing the Words of type integers");
            Console.WriteLine("--------------------------------");
            var intWords= from s in students.OfType<Student>()
                             select s;
            foreach(var sem in intWords)
            {
                Console.WriteLine(sem);
            }
            var query=students.OrderBy(x => x.Id);
            Console.WriteLine("Printing Names Order by Id");
            Console.WriteLine("--------------------------------");
            foreach (var student in query)
            {
                Console.WriteLine(student.Name);
            }
            var query1=students.OrderByDescending(x => x.Age);
            Console.WriteLine("Printing the Names Descending Order by Age");
            Console.WriteLine("--------------------------------");
            foreach (var ss in query1)
            {
                Console.WriteLine(ss.Name);
            }
            var query2=students.GroupBy(x => x.place);
            Console.WriteLine("Printing the Names Group by Place");
            Console.WriteLine("--------------------------------");
            foreach (var gg in query2)
            {
                Console.WriteLine(gg.Key,gg.Count());
                Console.WriteLine();
                foreach(var sit in gg)
                {
                    Console.WriteLine(sit.Name+"     "+sit.place);
                }
            }
        }
        
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string place { get; set; }
    }
}