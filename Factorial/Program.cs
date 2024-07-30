namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			long result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i; // result = result * i;
			}

			Console.WriteLine(result);
		}
	}
}