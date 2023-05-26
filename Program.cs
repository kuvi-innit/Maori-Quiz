namespace Maori_Quiz
{
    internal class Program
    {
        // Constants for difficulty levels
        private const string EasyDifficulty = "1";
        private const string MediumDifficulty = "2";
        private const string HardDifficulty = "3";

        public static void Main(string[] args)
        {
            // Introduction for the quiz
            Console.WriteLine("Welcome to the Maori Quiz!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Difficulty Selection
            string difficulty = GetDifficulty(name); // Pass the name to GetDifficulty method

            Console.Clear();
            Play(difficulty);
        }

        public static string GetDifficulty(string name) // Add name parameter
        {
            Console.WriteLine($"Hello, {name}"); // Use the provided name
            Console.WriteLine("Which level would you like to play: 1) Easy 2) Medium 3) Hard");

            string difficulty;
            do
            {
                difficulty = Console.ReadLine().ToLower();
                if (difficulty != EasyDifficulty && difficulty != MediumDifficulty && difficulty != HardDifficulty)
                {
                    Console.WriteLine("Please select a valid difficulty: 1, 2, or 3");
                }
            } while (difficulty != EasyDifficulty && difficulty != MediumDifficulty && difficulty != HardDifficulty);

            return difficulty;
        }

        public static void Play(string difficulty)
        {
            int score = 0;

            string[] questions;
            string[] answers;

            if (difficulty == EasyDifficulty)
            {
                questions = new string[] {
                "1. What is the Maori term for 'New Zealand'?\nA) Aotearoa\nB) Hawaii\nC) Australia\nD) Fiji",
                "2. What is the traditional Maori greeting?\nA) Aloha\nB) Kia Ora\nC) Hola\nD) Bonjour",
                "3. What animal is a symbol of New Zealand?\nA) Emu\nB) Kiwi\nC) Penguin\nD) Koala",
                "4. Who was the first person to discover New Zealand?\nA) Captain James Cook\nB) Abel Tasman\nC) Abraham Lincoln\nD) Barack Obama",
                "5. The Maori name for New Zealand means?\nA) Land Of Milk And Honey\nB) Australia's Brother\nC) Whale Rider\nD) Land of the long white cloud"
            };

                answers = new string[] { "A", "B", "B", "A", "D" };

                Console.WriteLine("You have selected the easy difficulty. Let's get started!");
            }
            else if (difficulty == MediumDifficulty)
            {
                questions = new string[] {
                "1. What does thank you mean in Moari?\nA) Nga Mihi\nB) Kia Ora\nC) Mihi Aroha\nD) Talofa",
                "2. What is the name of the famous Maori war dance?\nA) Haka\nB) Khalsa\nC) Ta tona\nD) Salsa",
                "3. What is the traditional method of cooking in Maori culture?\nA) Khanah\nB) Hangi\nC) Apa Tihi\nD) Oni Ma",
                "4. Who were the first people to settle in New Zealand?\nA) The Maori\nB) The Indian\nC) European\nD) Samoan",
                "5. What is the meaning of the word whanau in Maori?\nA) Friends\nB) Love\nC) Family\nD) Myself"
            };

                answers = new string[] { "A", "A", "B", "A", "C" };

                Console.WriteLine("You have selected the medium difficulty. Let's get started!");
            }
            else
            {
                questions = new string[] {
                "1. What term is used to describe the traditional Maori form of art? \nA) Tuhituhi\nB) Whakairo\nC) Whakapapa\nD) Kowhaiwhai",
                "2. What is the traditional Maori name for the South Island? \nA) Te Wai Pounamu\nB) Te Ika a Maui\nC) Te Aroha\nD) Te Manawa",
                "3. What is the name of the paddle used in Maori ceremonial welcomes? \nA) Hoho Paddle\nB) Waipura Paddle\nC) Waka Paddle\nD) Tera tahi Paddle",
                "4. What are the three baskets of knowledge in Maori culture?\nA) Basket of light, Basket of darkness, basket ball hoop
                    \nB) Basket of Power, Basket of Beauty, Basket of Hope\nC) Basket of light, Basket of darkness, Basket of Pursuit 
                    \nD) Basket of flowers, Basket of smiles, Basket of positivity",
                "5. What does the word “kia kaha” mean?\nA) Be weak\nB) Please come\nC) Thank you \nD) Stay strong"
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

