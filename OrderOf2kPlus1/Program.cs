namespace OrderOf2kPlus1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int sequenceNumber = 1; // Control variable
			while (sequenceNumber <= n) // Condition
			{
                Console.WriteLine(sequenceNumber);

				sequenceNumber = sequenceNumber * 2 + 1; //Change
            }
		}
	}
}