public class Book
{
    public Book(string name)
    {
        grades = new List<double>();
        this.name = name;
    }
    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }
   public List<double> grades;
    string name;
}  