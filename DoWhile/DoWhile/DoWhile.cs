using System;

public class DoWhile
{
	public static void Main()
	{
		int i = 0;

		do
		{
			Console.WriteLine("i = {0}", i);
			int j = i;

			i++;

			do
			{
				Console.WriteLine("j = {0}", j);
				j++;

			} while (j < 2);

		} while (i < 2);
	}
}