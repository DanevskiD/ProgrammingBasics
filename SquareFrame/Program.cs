﻿namespace SquareFrame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			// Print first line:

			/*Console.Write('+');
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write(" -");
			}

			Console.WriteLine(" +");*/

			PrintLine(n, '+');

			// Print middle line:

			for (int i = 0; i < n - 2; i++)
			{
				/*Console.Write('|');
				for (int j = 0; j < n - 2; j++)
				{
					Console.Write(" -");
				}

				Console.WriteLine(" |");*/
				PrintLine(n, '|');
			}

			// Print last line:

			/*Console.Write('+');
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write(" -");
			}

			Console.WriteLine(" +");*/

			PrintLine(n, '+');
		}

		static void PrintLine(int n, char borderSymbol)
		{
			Console.Write(borderSymbol);

			for (int i = 0; i < n - 2; i++)
			{
				Console.Write(" -");
			}
			Console.WriteLine($" {borderSymbol}");
		}
	}
}