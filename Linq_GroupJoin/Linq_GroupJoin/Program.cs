using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {  
            List<Department> objDept1 = new List<Department>()
            {  
                new Department{DepId=1,DepName="Software"},
                new Department{DepId=2,DepName="Finance"},
                new Department{DepId=3,DepName="Health"}
            };
            List<Employee> objEmp1 = new List<Employee>()
            {  
                new Employee { EmpId=1,Name = "Naveen", DeptId=1 },
                new Employee { EmpId=2,Name = "Satish", DeptId=1 },
                new Employee { EmpId=3,Name = "Mubeena", DeptId=2 },
                new Employee { EmpId=4,Name = "Harini", DeptId =2},
                new Employee { EmpId=5,Name = "Sai"}
            }; 
            var result = from d in objDept1
                         join e in objEmp1 on d.DepId equals e.DeptId into empDept
                         select new
                         {
                             DepartmentName = d.DepName,
                             Employees = from emp2 in empDept
                                         orderby emp2.Name
                                         select emp2
                         };
            int totalItems = 0;
            foreach (var empGroup in result)
            {
                Console.WriteLine(empGroup.DepartmentName);
                foreach (var item in empGroup.Employees)
                {
                    totalItems++;
                    Console.WriteLine("    {0}", item.Name);
                }
            }
            Console.ReadLine();
        }
    }
    class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
}