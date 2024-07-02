namespace Cinema
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string projectionType = Console.ReadLine();
			int rows = int.Parse(Console.ReadLine());
			int columns = int.Parse(Console.ReadLine());

			double ticketPrice = 0;
			if (projectionType == "Premiere")
			{
				ticketPrice = 12;
			}
			else if (projectionType == "Normal")
			{
				ticketPrice = 7.5;
			}
			else if (projectionType == "Discount")
			{
				ticketPrice = 5;
			}

			int totalSeats = rows * columns;
			double profit = totalSeats * ticketPrice;

            Console.WriteLine($"{profit:f2} euros");
        }
	}
}