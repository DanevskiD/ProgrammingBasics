namespace NumbersFrom1To100
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 1; // Control variable
			while (number <= 100) // Condition
			{
                Console.WriteLine(number);
				number = number + 1; // Change
            }

			/*
			 * for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(i);
			}
			*/
		}
	}
}