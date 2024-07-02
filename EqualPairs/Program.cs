namespace EqualPairs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int maxDiff = 0; // We use zero beacause we are interested in the absolute difference
			int lastPairSum = 0;

			for (int i = 0; i < n; i++)
			{
				int number1 = int.Parse(Console.ReadLine());
				int number2 = int.Parse(Console.ReadLine());

				int pairSum = number1 + number2;
				if (i > 0)
				{
					int currentDiff = Math.Abs(pairSum - lastPairSum);
					if (currentDiff > maxDiff)
					{
						maxDiff = currentDiff;
					}
				}

				lastPairSum = pairSum;
			}

			if (maxDiff == 0)
			{
                Console.WriteLine($"Yes, value={lastPairSum}");
            }
			else
			{
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
		}
	}
}