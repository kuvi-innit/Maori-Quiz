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
                // Easy Questions
                for (int i = 0; i < easyQuestions.Length; i++)
                {
                    Console.WriteLine(easyQuestions[i]);
                    string answerEasy = Console.ReadLine().ToUpper();

                    // Easy Answer Validation
                    while (answerEasy != "A" && answerEasy != "B" && answerEasy != "C" && answerEasy != "D")
                    {
                        Console.WriteLine("Please select a valid answer: A, B, C or D");
                        answerEasy = Console.ReadLine().ToUpper();
                    }

                    // Easy Score
                    if (answerEasy == easyAnswers[i])
                    {
                        Console.WriteLine("Correct"); scoreEasy++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                }
                Console.Clear();
                // Results
                Console.WriteLine("You have finished the quiz! Your score is: {0}/5", scoreEasy);
          
            
            }

            // array of medium questions and answers
            string[] mediumQuestions = {
               "1. What does thank you mean in Moari?\nA) Nga Mihi\nB) Kia Ora\nC) Mihi Aroha\nD) Talofa",
               "2. What is the name of the famous Maori war dance?\nA) Haka\nB) Khalsa\nC) Ta tona\nD) Salsa ",
               "3. What is the traditional method of cooking in Maori culture?\nA) Khanah\nB) Hangi\nC) Apa Tihi\nD) Oni Ma",
               "4. Who were the first people to settle in New Zealand?\nA) The Maori\nB) The Indian\nC) European\nD) Samoan",
               "5. What is the meaning of the word whanau in Maori?\nA) Friends\nB) Love\nC) Family\nD) Myself", };
            string[] mediumAnswers = { "A", "A", "B", "A", "C" };

            Console.WriteLine("You have selected the medium difficulty. Let's get started!");

            // medium Questions
            for (int i = 0; i < mediumQuestions.Length; i++)
            {
                Console.WriteLine(mediumQuestions[i]);
                string answermedium = Console.ReadLine().ToUpper();

                // medium Answer Validation
                while (answermedium != "A" && answermedium != "B" && answermedium != "C" && answermedium != "D")
                {
                    Console.WriteLine("Please select a valid answer: A, B, C or D");
                    answermedium = Console.ReadLine().ToUpper();
                }

                // medium Score
                if (answermedium == mediumAnswers[i])
                {
                    Console.WriteLine("Correct"); scoreMedium++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }

            // Results
            Console.Clear();
            Console.WriteLine("You have finished the quiz! Your score is: {0}/5", scoreMedium);
           
            // Hard Difficulty
            else if (difficulty == "3")
            {
                // array of hard questions and answers
                string[] hardQuestions = {
                "1. What term is used to describe the traditional Maori form of art? \nA) Tuhituhi\nB) Whakairo\nC) Whakapapa\nD) Kowhaiwhai",
                "2. What is the traditional Maori name for the South Island? \nA) Te Wai Pounamu\nB) Te Ika a Maui\nC) Te Aroha\nD) Te Manawa",
                "3. What is the name of the paddle used in Maori ceremonial welcomes? \nA) Hoho Paddle\nB) Waipura Paddle\nC) Waka Paddle\nD) Tera tahi Paddle",
                "4. What are the three baskets of knowledge in Maori culture?\nA) Basket of light, Basket of darkness, basket ball hoop\nB) Basket of Power, Basket of Beauty, Basket of Hope\nC) Basket of light, Basket of darkness, Basket of Pursuit \nD) Basket of flowers, Basket of smiles, Basket of positivity",
                "5. What does the word “kia kaha” mean?\nA) Be weak\nB) Please come\nC) Thank you \nD) Stay strong ", };
                string[] hardAnswers = { "B", "A", "A", "C", "D" };

                Console.WriteLine("You have selected the hard difficulty. Let's get started!");


            }

    }

}