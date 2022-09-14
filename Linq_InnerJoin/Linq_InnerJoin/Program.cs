using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> Dept = new List<Department>()
            {
                new Department{DepId=1,DepName="Software"},
                new Department{DepId=2,DepName="Finance"},
                new Department{DepId=3,DepName="Health"}
            };
            List<Employee> Emp = new List<Employee>()
            {
                new Employee { EmpId=1,Name = "Naveen", DeptId=1 },
                new Employee { EmpId=2,Name = "Sai", DeptId=1 },
                new Employee { EmpId=3,Name = "Satish", DeptId=2 },
                new Employee { EmpId=4,Name = "Mubeena", DeptId =2},
                new Employee { EmpId=5,Name = "Harini"}
            };
            var result = from d in Dept
                         join e in Emp
                         on d.DepId equals e.DeptId
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