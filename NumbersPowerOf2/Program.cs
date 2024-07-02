namespace NumbersPowerOf2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*int result = 1;
			for (int i = 0; i <= n; i++)
			{
                Console.WriteLine(result);
				result *= 2;
            }*/

			/*for (int i = 0, result = 1; i <= n; i++, result *= 2)
			{
                Console.WriteLine(result);
            }*/

			int result = 1;
			int power = 0;

			while (power <= n)
			{
                Console.WriteLine(result);

				power++;
				result *= 2;
            }
		}
	}
}