// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more informatio
using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Caching.SqlServer;
using System.Collections.Generic;

namespace DapperExample
{
    class Program
    {
        class students
        {
            public int Id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string branch
            {
                get;
                set;
            }

            public override string ToString()
            {
                return $"{Id} {name} {age} {branch}";
            }
        }
        static void Main(string[] args)
        {
            var cs = @"Server=DESKTOP-S4GAE3H;Database=master;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();
            var details = con.Query<students>("select * from students").ToList();
            details.ForEach(stu => Console.WriteLine(stu));

            var insert = con.Query<students>("insert into students(id,name,age,branch) values(2060,'sreeveni',23,'cse')").ToList();
            insert.ForEach(ins => Console.WriteLine(ins));

            var afterinsert = con.Query<students>("select * from students").ToList();
            afterinsert.ForEach(stu => Console.WriteLine(stu));

            var update = con.Query<students>("update students set branch='RGUKT'").ToList();
            update.ForEach(ins => Console.WriteLine(ins));

            var afterupdate = con.Query<students>("select * from students").ToList();
            afterupdate.ForEach(stu => Console.WriteLine(stu));

            var delete = con.Query<students>("delete from students where Id=2060").ToList();
            delete.ForEach(ins => Console.WriteLine(ins));

            var afterdelete = con.Query<students>("select * from students").ToList();
            afterdelete.ForEach(stu => Console.WriteLine(stu));

        }
    }
}




