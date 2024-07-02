namespace SquareFrame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			// Print first line:
			Console.Write('+');
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write(" -");
			}

			Console.WriteLine(" +");

			// Print middle line:

			for (int i = 0; i < n - 2; i++)
			{
				Console.Write('|');
				for (int j = 0; j < n - 2; j++)
				{
					Console.Write(" -");
				}

				Console.WriteLine(" |");
			}

			// Print last line:

			Console.Write('+');
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write(" -");
			}

			Console.WriteLine(" +");
		}
	}
}