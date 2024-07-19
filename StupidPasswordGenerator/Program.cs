namespace StupidPasswordGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int l = int.Parse(Console.ReadLine());

			int finalLetter = 'a' + l; // l = 1 => finalLetter = 'b'

			for (int i1 = 1; i1 < n; i1++)
			{
				for (int i2 = 1; i2 < n; i2++)
				{
					for (char i3 = 'a'; i3 < finalLetter; i3++)
					{
						for (char i4 = 'a'; i4 < finalLetter; i4++)
						{
							/*for (int i5 = 1; i5 <= n; i5++)
							{
								if (i5 > i1 && i5 > i2)
								{
									Console.Write($"{i1}{i2}{i3}{i4}{i5} ");
								}
							}*/

							for (int i5 = Math.Max(i1, i2) + 1; i5 <= n; i5++)
							{
								Console.Write($"{i1}{i2}{i3}{i4}{i5} ");
							}
						}
					}
				}
			}
		}
	}
}