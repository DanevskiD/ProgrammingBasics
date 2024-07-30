namespace DiamondOfStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				PrintLine(i, n);
			}

			for (int i = n - 1; i >= 1; i--)
			{
				PrintLine(i, n);
			}
		}

		static void PrintLine(int line, int n)
		{
			Console.Write(new string(' ', n - line));

			for (int i = 0; i < line; i++)
			{
                Console.Write("* ");
            }
            Console.WriteLine();
        }
	}
}