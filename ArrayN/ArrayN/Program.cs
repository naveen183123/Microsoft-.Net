using System;
class Program
{
    public static void Main(string[] args)
    {
        string[] answer = new string[5];
        int n = answer.Length;
        for (int i = 0; i < n; i++)
        {
            answer[i] = Console.ReadLine();
        }
        foreach(string print in answer)
        {
            Console.WriteLine(print);
        }  
    }
}