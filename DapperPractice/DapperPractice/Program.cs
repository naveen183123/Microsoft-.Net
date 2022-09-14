using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
namespace DapperExample
{
    class Program
    {
        class Employee
        {
            public int EmployeeId { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Email { get; set; }
            public string City { get; set; }

            public override string ToString()
            {
                return $"{EmployeeId} {FirstName} {City} {Email}";
            }
        }
        static void Main(string[] args)
        {
            var connectionstring = @"Server=NAVEEN-VAKAMALL;Database=EmployeeDB;Trusted_Connection=True;";
            using var con = new SqlConnection(connectionstring);
            con.Open();
            var cars = con.Query<Employee>("SELECT * FROM Employee").ToList();
            cars.ForEach(car => Console.WriteLine(car));
        }
    }
}