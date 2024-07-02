namespace Histogram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0, counter5 = 0;
			for (int i = 0; i < n; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());

				if (currentNumber < 200)
				{
					// First category
					counter1++;
				}
				else if (currentNumber < 400)
				{
					// Second category
					counter2++;
				}
				else if (currentNumber < 600)
				{
					// Third category
					counter3++;
				}
				else if (currentNumber < 800)
				{
					// Fourth category
					counter4++;
				}
				else
				{
					// Fifth category
					counter5++;
				}
			}

			double percentage1 = 1.0 * counter1 / n * 100;
			double percentage2 = 1.0 * counter2 / n * 100;
			double percentage3 = 1.0 * counter3 / n * 100;
			double percentage4 = 1.0 * counter4 / n * 100;
			double percentage5 = 1.0 * counter5 / n * 100;

            Console.WriteLine($"{percentage1:f2}%");
            Console.WriteLine($"{percentage2:f2}%");
            Console.WriteLine($"{percentage3:f2}%");
            Console.WriteLine($"{percentage4:f2}%");
            Console.WriteLine($"{percentage5:f2}%");
        }
	}
}