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

            Console.Clear();

            Console.WriteLine("Hello, " + name + "!"); Console.WriteLine("Which level would you like to play?");
            Console.WriteLine("1 - Born Yesterday");
            Console.WriteLine("2 - Beginner");
            Console.WriteLine("3 - Intermediate");
            Console.WriteLine("4 - Expert");
            Console.WriteLine("5 - Albert Einstein");
            
            string level;
            bool levelExists = false;
            do
            {
                Console.Write("Enter your choice (1-5): ");
                level = Console.ReadLine();

                if (level == "1")
                {
                    levelExists = true;
                }
                else if (level == "2")
                {
                    levelExists = true;
                }
                else if (level == "3")
                {
                    levelExists = true;
                }
                else if (level == "4")
                {
                    levelExists=true;
                }
                else if (level == "5")
                {
                    levelExists=(true);
                }
            } while (levelExists == false);
            Console.Clear();
            Console.WriteLine($"You have chosen level {level}!");
            Console.WriteLine("\nGood luck and have fun!");
      
        
        }
    }
}