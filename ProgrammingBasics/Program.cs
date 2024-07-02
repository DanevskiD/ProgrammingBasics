namespace ProgrammingBasics
{
	public class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, {0} {1}! You are {2} years old.", firstName, lastName, age);

			// Concatenation (concat/concatenate) -addition with strings
			string result = "Hello, " + firstName + " " + lastName + "! You are " + age + " years old.";
            Console.WriteLine(result);

            // Interpolation
            Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} years old.");
        }
	}
}