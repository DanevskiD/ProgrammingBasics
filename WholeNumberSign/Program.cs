namespace WholeNumberSign
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			string text = PrintNumberSign(number);
            Console.WriteLine(text);
        }

		/*static void PrintNumberSign(int number)
		{
			if (number > 0)
			{
                Console.WriteLine($"The number {number} is positive.");
            }
			else if (number < 0)
			{
                Console.WriteLine($"The number {number} is negative.");
            }
			else
			{
				Console.WriteLine($"The number {number} is zero.");
			}
		}*/
		
		static string PrintNumberSign(int number)
		{
			if (number > 0)
			{
                return $"The number {number} is positive.";
            }
			else if (number < 0)
			{
                return $"The number {number} is negative.";
            }
			else
			{
				return $"The number {number} is zero.";
			}
		}
	}
}