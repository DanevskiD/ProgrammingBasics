namespace MaxNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int max = int.MinValue; // Minimal initial value

			for (int i = 0; i < n; i++)
			{
				int currentElement = int.Parse(Console.ReadLine());
				if (currentElement > max)
				{
					max = currentElement;
				}
			}

			Console.WriteLine(max);
		}
	}
}