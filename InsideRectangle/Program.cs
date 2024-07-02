namespace InsideRectangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double topLeftX = double.Parse(Console.ReadLine());
			double topLeftY = double.Parse(Console.ReadLine());
			double bottomRightX = double.Parse(Console.ReadLine());
			double bottomRightY = double.Parse(Console.ReadLine());

			double pointX = double.Parse(Console.ReadLine());
			double pointY = double.Parse(Console.ReadLine());

			bool isInside = topLeftX <= pointX && pointX <= bottomRightX
				&& topLeftY <= pointY && pointY <= bottomRightY;

			if (isInside )
			{
				Console.WriteLine("Inside");
			}
			else
			{
				Console.WriteLine("Outside");
			}
        }
	}
}