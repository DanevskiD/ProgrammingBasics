﻿namespace RectangleOfNxNStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*for (int i = 0; i < n; i++)
			{
				string row = new string('*', n);
                Console.WriteLine(row);
            }*/

			for (int i = 0; i < n; i++)
			{
				PrintLine(n);
			}
		}

		static void PrintLine(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write("* ");
			}
            Console.WriteLine();
        }
	}
}