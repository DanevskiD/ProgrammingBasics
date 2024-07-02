namespace OnTimeForExam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int examHour = int.Parse(Console.ReadLine());
			int examMinute = int.Parse(Console.ReadLine());
			int arrivalHour = int.Parse(Console.ReadLine());
			int arrivalMinute = int.Parse(Console.ReadLine());

			int examTime = examHour * 60 + examMinute;
			int arrivalTime = arrivalHour * 60 + arrivalMinute;

			int difference = examTime - arrivalTime;

			if (difference < 0)
			{
                Console.WriteLine("Late");
            }
			else if (difference <= 30)
			{
                Console.WriteLine("On time");
            }
			else
			{
                Console.WriteLine("Early");
            }

			if (difference != 0)
			{
				int absoluteDifference = Math.Abs(difference);
				int diffHours = absoluteDifference / 60;
				int diffMinutes = absoluteDifference % 60;

				if (diffHours == 0)
				{
                    Console.Write($"{diffMinutes} minutes");
                }
				else
				{
					if (diffMinutes < 10)
					{
                        Console.Write($"{diffHours}:0{diffMinutes} hours");
                    }
					else
					{
                        Console.Write($"{diffHours}:{diffMinutes} hours");
                    }
                }

				if (difference < 0)
				{
                    Console.Write(" after ");
                }
				else
				{
                    Console.Write(" before ");
                }

                Console.WriteLine("the start");
            }
		}
	}
}