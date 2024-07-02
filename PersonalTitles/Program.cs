namespace PersonalTitles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double age = double.Parse(Console.ReadLine());
			string gender = Console.ReadLine();

			// 1. Avoid using nested conditional statements
			/*if (age >= 16 && gender == "m")
			{
                Console.WriteLine("Mr.");
            }
			else if (age < 16 && gender == "m")
			{
                Console.WriteLine("Master");
            }
			else if (age >= 16 && gender == "f")
			{
				Console.WriteLine("Ms.")
			}
			else if (age < 16 && gender == "f")
			{
				Console.WriteLine("Miss");
			}*/

			// 2. First, check the gender. Then check the age
			/*if (gender =="m")
			{
				if (age >= 16)
				{
                    Console.WriteLine("Mr.");
                }
				else 
				{
                    Console.WriteLine("Master");
                }
			}
			else if (gender =="f")
			{
				if(age >=16)
				{
                    Console.WriteLine("Ms.");
                }
				else
				{
                    Console.WriteLine("Miss");
                }
			}*/
			// 3. First, check the age. Then, check the gender.
			if (age >= 16)
			{
				if (gender == "m")
				{
                    Console.WriteLine("Mr.");
                }
				else if (gender == "f")
				{
                    Console.WriteLine("Ms.");
                }
			}
			else
			{
				if(gender == "m")
				{
					Console.WriteLine("Master");
				}
				else if(gender == "f")
				{
                    Console.WriteLine("Miss");
                }
			}
		}
	}
}