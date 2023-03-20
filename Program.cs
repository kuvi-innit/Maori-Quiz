namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask the user to input their name and the level which they would like to play according to difficulty
            Console.WriteLine("Welcome to the Maori Quiz!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!"); Console.WriteLine("Which level would you like to play?");
            Console.WriteLine("1 - Beginner");
            Console.WriteLine("2 - Intermediate");
            Console.WriteLine("3 - Expert"); int level;
            do
            {
                Console.Write("Enter your choice (1-3): ");
                level = Convert.ToInt32(Console.ReadLine());
            } while (level < 1 || level > 3); Console.WriteLine($"You have chosen level {level}.");
            Console.WriteLine("Good luck and have fun!");
        }
    }
}