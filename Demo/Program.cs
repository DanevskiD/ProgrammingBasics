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

			/*for (int i = 7; i <= 1000; i++)
			{
				if (i % 10 == 7)
				{
					Console.WriteLine(i);
				}
			}

			for (int i = 7; i <= 1000; i += 10)
			{
				Console.WriteLine(i);
			}*/

			// int end  = int.Parse(Console.ReadLine());

			/*int number = 1;
			while (number <= end) // If 'end' is less than 1, nothing is displayed 
			{
                Console.WriteLine(number);
				number++;
            }*/

			/*int number = 1;
			do // If 'end' is less than 1, the body will be still executed once because of the way do-while works.
			{
                Console.WriteLine(number);
				number++;
            }
			while (number > end);*/

			/*int number = int.Parse(Console.ReadLine());

			for (int i = 1; i <= 100; i++)
			{
                Console.WriteLine($"This is the start of iteration #{i}");
				if (i == number)
				{
					// break; // Nothing else from the current loop will be executed; proceed with next instructions

					continue; // Nothing else from the current iteration will be executed; proceed with next iteration
				}
                Console.WriteLine($"This is the end of iteration #{i}");
            }

            Console.WriteLine("This is the end of our program!");*/

			/*for (int i = 0; i <= 9; i++)
			{
                Console.WriteLine($"Start of iteration #{i}");

                for (int j = 0; j < 9; j++)
				{
                    Console.WriteLine($"i = {i}, j = {j}");
                }

                Console.WriteLine($"End of iteration #{i}");
			}*/

			// PrintDayInfo();

			/*double temperatureInFahrenheit = double.Parse(Console.ReadLine());
			double temperatureInCelsius = FahrenheitToCelsius(temperatureInFahrenheit);
            Console.WriteLine(temperatureInCelsius);*/

			/*double side = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			double area = CalculateTriangleArea(side, height);
            Console.WriteLine(area);*/

			/*double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());

			double result = RaiseToPower(number, power);
            Console.WriteLine(result);*/

			Console.WriteLine("First line!");
			PrintMiddleLines();
			Console.WriteLine("Fourth line!");
        }

		static void PrintDayInfo()
		{
            Console.WriteLine("It's snowing. It's cold outside.");
        }

		static double FahrenheitToCelsius(double degrees)
		{
			return (degrees - 32) * 5 / 9;
		}

		static double CalculateTriangleArea(double side, double height)
		{
			return side * height / 2;
		}

		static double RaiseToPower(double n, int p)
		{
			double result = 1;
			for (int i = 0; i < p; i++)
			{
				result *= n;
			}
			return result;
		}

		static void PrintMiddleLines()
		{
            Console.WriteLine("Second line!");
            Console.WriteLine("Third line!");
        }
	}
}