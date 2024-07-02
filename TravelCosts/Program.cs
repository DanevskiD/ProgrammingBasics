namespace TravelCosts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int distance = int.Parse(Console.ReadLine());
			string partOfday = Console.ReadLine();

			double price = 0;
			if (distance<20)
			{

				if (partOfday == "day")
				{
					price = 0.7 + 0.79 * distance;
				}
				else if (partOfday == "night")
				{
					price = 0.7 + 0.9 * distance;
				}
			}
			else if (distance<100) 
			{
				price = 0.09 * distance;
			}
			else 
			{
				price = 0.06 * distance;
			}

			//Console.WriteLine($"{price:f2}");

			price = Math.Round(price, 2);
			Console.WriteLine(price);
		}
	}
}