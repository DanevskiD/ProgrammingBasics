namespace ChristmasTree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string stars = new string('*', i);
				string whiteSpaces = new string(' ', n - i);

				Console.WriteLine($"{whiteSpaces}{stars} | {stars}{whiteSpaces}");
            }
		}
	}
}