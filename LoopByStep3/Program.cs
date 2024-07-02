namespace LoopByStep3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*for (int i = 1; i <= n; i++)
			{
                if (i % 3 == 1)
                {
                    Console.WriteLine(i);
                }
            }*/

			for (int i = 1; i <= n; i += 3)
			{
				Console.WriteLine(i);
			}
		}
	}
}