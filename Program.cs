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
           
            // Easy Difficulty
            if (difficulty == "1")
            {
                string[] easyQuestions = {
                "1. What is the Maori term for 'New Zealand'?\nA) Aotearoa\nB) Hawaii\nC) Australia\nD) Fiji",
                "2. What is the traditional Maori greeting?\nA) Aloha\nB) Kia Ora\nC) Hola\nD) Bonjour",
                "3. What animal is a symbol of New Zealand?\nA) Emu\nB) Kiwi\nC) Penguin\nD) Koala",
                "4. Who was he first person to discover New Zealand?\nA) Captain James Cook\nB) Abel Tasman\nC) Abraham Lincoln\nD) Barack Obama",
                "5. The Maori name for New Zealand means?\nA) Land Of Milk And Honey\nB) Australia's Brother\nC) Whale Rider\nD) Land of the long white cloud", };

                string[] easyAnswers = { "A", "B", "B", "A", "D" };

                Console.WriteLine("You have selected the easy difficulty. Let's get started!");




            }
        }
}