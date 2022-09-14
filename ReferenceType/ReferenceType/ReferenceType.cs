using System;
namespace References
{
    public class Student
    {
        public String StudentName { get; set; }
    }
    class Reference
    {
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Naveen";
        }
        public static void Main()
        {
            Student std1 = new Student();
            std1.StudentName = "Anji";
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);
        }
    }
}