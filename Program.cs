namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name;
            string difficulty;
            int scoreEasy = 0;
            int scoreMedium = 0;
            int scoreHard = 0;

            // Introduction for the quiz
            Console.WriteLine("Welcome to the Moari Quiz!");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
          
            // Difficulty Selection Validation
            while (difficulty != "1" && difficulty != "2" && difficulty != "3")
            {
                Console.WriteLine("Please select a valid difficulty: 1 or 2 or 3");
                difficulty = Console.ReadLine().ToLower();
            }
            Console.Clear();
        }
    }
}