namespace CountDigitsOfNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int count = 0;
			do
			{
				// int lastDigit = number % 10;
				count++;

				number = number / 10;
			}
			while (number != 0);

            Console.WriteLine($"This number has {count} digits.");
        }
	}
}