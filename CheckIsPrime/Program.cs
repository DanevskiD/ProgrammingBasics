namespace CheckIsPrime
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());

			for (int number = start; number <= end; number++)
			{

				bool isPrime = true;
				double squareRoot = Math.Sqrt(number);
				for (int i = 2; i <= squareRoot; i++) // i = 2, 3, 4, ..., sqrt(number)
				{
					if (number % i == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
				{
					Console.WriteLine($"{number} is a prime number!");
				}
				else
				{
					Console.WriteLine($"{number} is a composite number!");
				}
			}
		}
	}
}