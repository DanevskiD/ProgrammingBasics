namespace UnitConverter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const double meterToMilimeter = 1000;
			const double meterToCentimeter = 100;
			const double meterToMile = 0.000621371192;
			const double meterToInch = 39.3700787;
			const double meterToKilometer = 0.001;
			const double meterToFoot = 3.2808399;
			const double meterToYard = 1.0936133;

			double quantity = double.Parse(Console.ReadLine());
			string inUnit = Console.ReadLine();
			string outUnit = Console.ReadLine();

			// 1. Convert from "inUnit" to meters
			double quantityInMeters = 0;

			if (inUnit == "mm")
			{
				quantityInMeters = quantity / meterToMilimeter;
			}
			else if (inUnit == "cm")
            {
				quantityInMeters = quantity / meterToCentimeter;
            }
			else if (inUnit =="mi") 
			{
				quantityInMeters = quantity / meterToMile;
			}
			else if (inUnit =="in") 
			{
				quantityInMeters = quantity / meterToInch;
			}
			else if (inUnit =="km") 
			{
				quantityInMeters = quantity / meterToKilometer;
			}
			else if (inUnit =="ft") 
			{
				quantityInMeters = quantity / meterToFoot;
			}
			else if (inUnit =="yd") 
			{
				quantityInMeters = quantity / meterToYard;
			}
			else if (inUnit == "m")
			{
				quantityInMeters = quantity;
			}

			// 2. Convert from meters to "outUnit"
			double result = 0;

			if (outUnit == "mm")
			{
				result = quantityInMeters * meterToMilimeter;
			}
			else if (outUnit == "cm")
			{
				result = quantityInMeters * meterToCentimeter;
			}
			else if (outUnit == "mi")
			{
				result = quantityInMeters * meterToMile;
			}
			else if (outUnit == "in")
			{
				result = quantityInMeters * meterToInch;
			}
			else if (outUnit == "km")
			{
				result = quantityInMeters * meterToKilometer;
			}
			else if (outUnit == "ft")
			{
				result = quantityInMeters * meterToFoot;
			}
			else if (outUnit == "yd")
			{
				result = quantityInMeters * meterToYard;
			}
			else if (outUnit == "m")
			{
				result = quantityInMeters;
			}

			Console.WriteLine($"{result} {outUnit}");

        }
	}
}