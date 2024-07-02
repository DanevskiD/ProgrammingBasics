namespace NumbersEnding7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*for (int i = 1; i <= 1000; i++)
			{
				if (i % 10 == 7)
				{
					Console.WriteLine(i);
				}
			}*/

			/*
			 * for (int i = 7; i <= 997; i+=10)
			{
					Console.WriteLine(i);
			}
			*/

			int number = 7;
			while (number <= 997)
			{
                Console.WriteLine(number);

				// How to change the number?
				number += 10;
            }
		}
	}
}