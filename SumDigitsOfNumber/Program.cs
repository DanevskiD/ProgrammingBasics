﻿namespace SumDigitsOfNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int sum = 0;
			/*while (number != 0)
			{
				int lastDigit = number % 10;
				sum += lastDigit;

				number /= 10;
			}*/

			do
			{
				int lastDigit = number % 10;
				sum += lastDigit;

				number /= 10;
			}
			while (number != 0);

			Console.WriteLine(sum);
        }
	}
}