namespace PrintTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
                    Console.Write($"{j} ");
                }
				Console.WriteLine();
			}

			for (int i = n - 1; i >= 1; i--)
			{
				for(int j = 1; j <= i; j++)
				{
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }*/

			for (int i = 1; i <= n; i++)
			{
				PrintLine(i);
			}

			for (int i = n - 1; i >= 1; i--)
			{
				PrintLine(i);
			}
		}

		static void PrintLine(int end)
		{
			for (int i = 1; i <= end; i++)
			{
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();
        }
	}
}