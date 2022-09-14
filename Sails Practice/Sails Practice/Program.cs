using System;
public class GFG
{
	static public void Main(string[] args)
	{
		var book=new Book("Naveen V");
		book.AddGrade(89.1);
		book.AddGrade(90.5);
		book.grades.Add(101);
		var grades=new List<double>() { 99.9,88.8,96.6,97.3};
		grades.Add(95.6);
		var result = 0.0;
		foreach (var number  in grades)
        {
			result += number;
        }
		result /= grades.Count;
		Console.WriteLine(result);
		
	}
}
