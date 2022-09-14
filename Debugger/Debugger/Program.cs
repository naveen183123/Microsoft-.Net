using System;
class Arrays
{
    public static void Main(string[] args)
    {
        int[] array = { 55, 45, 67, 123, 68, 1, 64, 7 };
        Array.Sort(array);
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        string[] arr = new string[5] { "Naveen", "Srujana", "Poojitha", " ", " " };
        arr[3] = "Narasimha Reddy";
        arr[4] = "Lakshmi Devi";
        Array.Sort(arr);
        foreach (string i in arr)
        {
            Console.WriteLine(i);
        }
        int[,] xy = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        foreach (int i in xy)
        {
            Console.WriteLine(i);
        }
        int[,,] xyz = new int[,,] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        foreach (int n in xyz)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(arr);
        Console.WriteLine(array);
        Console.WriteLine(array);
        Console.ReadLine();
    }
}