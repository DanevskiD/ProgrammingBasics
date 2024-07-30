namespace House
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int roofLines = (n + 1) / 2;
			int bodyLines = n - roofLines; // n / 2

			for (int i = 0; i < roofLines; i++)
			{
				PrintRoofLine(roofLines - (i + 1), n);
			}

			for (int i = 0; i < bodyLines; i++)
			{
				PrintBodyLine(n);
			}
		}

		static void PrintRoofLine(int offset, int n)
		{
			string dashes = new string('-', offset);
			string stars = new string('*', n - 2 * offset);

            Console.WriteLine($"{dashes}{stars}{dashes}");

		}

		static void PrintBodyLine(int n)
		{
            Console.WriteLine($"|{new string('*', n - 2)}|");
        }
	}
}