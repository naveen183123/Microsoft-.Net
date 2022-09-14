using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Programme2
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
            var result = from e in objEmp1
                         from d in objDept1
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.DepName
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.EmployeeName + "\t | " + item.DepartmentName);
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