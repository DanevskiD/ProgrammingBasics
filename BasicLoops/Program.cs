namespace BasicLoops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int product = 1;
			int count = 0;

			int number = int.Parse(Console.ReadLine()); // Control variable
			while (number != 0) // Condition
			{
				sum = sum + number;
				product = product * number;
				count = count + 1;

				number = int.Parse(Console.ReadLine()); // Change
			}

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Count: {count}");


            /*
             * int number = 1; // Control variable

			while (number < 100) // Condition
			{
                Console.WriteLine(number);

				number *= 2; //Change
            }

            Console.WriteLine("This is the end of our program!");
			*/

        }
	}
}