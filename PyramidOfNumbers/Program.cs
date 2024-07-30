namespace PyramidOfNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*int row = 1;
			int numberToPrint = 1;

			while (numberToPrint <= n)
			{
				// Print numbers for the current row
				for (int i = 0; i < row && numberToPrint <= n; i++)
				{
                    Console.Write($"{numberToPrint} ");
					numberToPrint++;

					// if (numberToPrint > n) break;
                }
                Console.WriteLine();
				row++;
            }*/

			int row = 1;
			int column = 1;
			for (int i = 1; i <= n; i++)
			{
                Console.Write($"{i} ");

				column++;
				if (column > row)
				{
					row++;
					column = 1;

                    Console.WriteLine();
                }
            }
		}
	}
}