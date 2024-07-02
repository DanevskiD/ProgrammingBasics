namespace TimePlusFifteenMinutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());

			// hours = 5; minutes = 10 => 5:25
			// hours = 6; minutes = 45 => 7:00
			// hours = 7; minutes = 59 => 8:14

			minutes = minutes + 15;
			if (minutes >= 60)
			{
				hours = hours + 1;
				minutes = minutes - 60;
			}

			if (hours == 24)
			{
				hours = 0;
			}

			if (minutes < 10)
			{
                Console.WriteLine($"{hours}:0{minutes}");
            }
			else
			{
				Console.WriteLine($"{hours}:{minutes}");
			}
		}
	}
}