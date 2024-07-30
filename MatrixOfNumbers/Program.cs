namespace MatrixOfNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				// Print all numbers of the current row
				for (int j = 0; j < n; j++)
				{
					int currentCell = i + j + 1;
					if (currentCell > n)
					{
						currentCell = 2 * n - currentCell;
						// currentCell = currentCell - 2 * (currentCell % n);
					}
                    Console.Write($"{currentCell} ");
                }
                Console.WriteLine();
            }
		}
	}
}