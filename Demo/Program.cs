namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, {0} {1}! You are {2} years old.", firstName, lastName, age);

			// Concatenation (concat/concatenate) -addition with strings
			string result = "Hello, " + firstName + " " + lastName + "! You are " + age + " years old.";
			Console.WriteLine(result);

			// Interpolation
			Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} years old.");*/

			/*
			 * // We should check if the number is within the [50; 100] interval
			int number = int.Parse(Console.ReadLine());
			// bool isGreaterThanOrEqualToFifty = number >= 50;
			// bool isLowerThanOrEqualToHundred = number <= 100;

			// number = 10 => false && true => false
			// number = 60 => true && true => true
			// numer = 140 => true && false => false
			// bool isInRange = isGreaterThanOrEqualToFifty && isLowerThanOrEqualToHundred;
			bool isInRange = number >= 50 && number <= 100;
            Console.WriteLine($"Is the number in range [50; 100]? {isInRange}");

			bool isEvenOrEndsInSeven = number % 2 == 0 || number % 10 == 7;
            Console.WriteLine($"Is the number even or does it end in seven? {isEvenOrEndsInSeven}");
			*/

			/*
			 * int testNumber = int.Parse(Console.ReadLine());

			if (testNumber > 10)
			{
				int nextNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(nextNumber);
            }
            Console.WriteLine(testNumber);
			*/

			/*
			 * for (char i = 'a'; i <= 'z'; i++)
			{
                Console.WriteLine(i);
            }
			*/

			/*
			 * for (int i = 1; i <= 20; i++)
			{
                Console.WriteLine(i);
            }

			for (int i = 20; i >= 1; i--)
			{
				Console.WriteLine(i);
			}
			*/

			for (int i = 7; i <= 1000; i++)
			{
				if (i % 10 == 7)
				{
					Console.WriteLine(i);
				}
			}

			for (int i = 7; i <= 1000; i += 10)
			{
				Console.WriteLine(i);
			}
		}
	}
}