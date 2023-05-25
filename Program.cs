namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Introduction for the quiz
            Console.WriteLine("Welcome to the Maori Quiz!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Difficulty Selection
            string difficulty = GetDifficulty();

            Console.Clear();
            Play(difficulty);
        }

        public static string GetDifficulty()
        {
            string difficulty;
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("Which level would you like to play: 1) Easy 2) Medium 3) Hard");

            do
            {
                difficulty = Console.ReadLine().ToLower();
                if (difficulty != "1" && difficulty != "2" && difficulty != "3")
                {
                    Console.WriteLine("Please select a valid difficulty: 1, 2, or 3");
                }
            } while (difficulty != "1" && difficulty != "2" && difficulty != "3");

            return difficulty;
        }

        public static void Play(string difficulty)
        {
            int score = 0;

            string[] questions;
            string[] answers;

            if (difficulty == "1")
            {
                questions = new string[] {
                    "1. What is the Maori term for 'New Zealand'?\nA) Aotearoa\nB) Hawaii\nC) Australia\nD) Fiji",
                    // ...
                };
                answers = new string[] { "A", "B", "B", "A", "D" };

                Console.WriteLine("You have selected the easy difficulty. Let's get started!");
            }
            else if (difficulty == "2")
            {
                questions = new string[] {
                    "1. What does thank you mean in Maori?\nA) Nga Mihi\nB) Kia Ora\nC) Mihi Aroha\nD) Talofa",
                    // ...
                };
                answers = new string[] { "A", "A", "B", "A", "C" };

                Console.WriteLine("You have selected the medium difficulty. Let's get started!");
            }
            else
            {
                questions = new string[] {
                    "1. What term is used to describe the traditional Maori form of art?\nA) Tuhituhi\nB) Whakairo\nC) Whakapapa\nD) Kowhaiwhai",
                    // ...
                };
                answers = new string[] { "B", "A", "A", "C", "D" };

                Console.WriteLine("You have selected the hard difficulty. Let's get started!");
            }

            // Questions
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string input = GetValidAnswer();

                // Score
                if (input.Contains(answers[i]))
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }

            Console.Clear();
            // Results
            Console.WriteLine($"You have finished the quiz! Your score is: {score}/{questions.Length}");
        }

        public static string GetValidAnswer()
        {
            string input;
            do
            {
                input = Console.ReadLine().ToUpper();
                if (input != "A" && input != "B" && input != "C" && input != "D")
                {
                    Console.WriteLine("Please select a valid answer: A, B, C, or D");
                }
            } while (input != "A" && input != "B" && input != "C" && input != "D");

            return input;
        }
    }
}

