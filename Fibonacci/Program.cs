namespace Fibonacci
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			long firstNumber = 1;
			long secondNumber = 1;

			for (int i = 2; i <= n; i++)
			{
				long nextNumber = firstNumber + secondNumber;

				firstNumber = secondNumber;
				secondNumber = nextNumber;
			}
			Console.WriteLine(secondNumber);

		}
	}
}