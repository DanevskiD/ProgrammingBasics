namespace SunGlasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			PrintLine('*', ' ',n);

			int middlePosition;
			if (n % 2 == 0) middlePosition = n / 2;
			else middlePosition = (n + 1) / 2;

			for (int i = 0; i < n - 2; i++)
			{
				if (i + 2 == middlePosition) PrintLine('/', '|', n);
				else PrintLine('/', ' ', n);
			}
			PrintLine('*', ' ', n);
		}

		static void PrintLine (char filler, char separator, int n)
		{
			string fillerString = new string(filler, 2 * n - 2);
			string separatorString = new string(separator, n);
            Console.WriteLine($"*{fillerString}*{separatorString}*{fillerString}");
        }
	}
}