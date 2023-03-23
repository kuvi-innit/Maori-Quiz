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
            //end of Level method 
            int score = 0;
            string questioninput;
            bool questioninputExists = false;
            do
            {
                questioninput=Console.ReadLine();
                if (questioninput =="A")
            {
                questioninputExists = true;
            }
            else if (questioninput == "B")
            {
                questioninputExists = true;
            }
            else if (questioninput == "C")
            {
                questioninputExists = true;
            }
            else if (questioninput == "D")
            {
                questioninputExists = true;
            }
                Console.WriteLine("Welcome to the Maori Quiz!");



                Console.WriteLine("Answer the following questions by typing the letter of the correct answer.");
                Console.WriteLine("1. What is the Maori word for hello?");
                Console.WriteLine("A. Kia ora");
                Console.WriteLine("B. Haere mai");
                Console.WriteLine("C. Ka kite ano");
                Console.WriteLine("D. Nau mai");
                string answer1 = Console.ReadLine().ToUpper();
                if (answer1 == "A") { Console.WriteLine("Correct!"); score++; }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is A.");
                }
                Console.WriteLine("2. What is the meaning of the word 'whanau'?");
                Console.WriteLine("A. Family");
                Console.WriteLine("B. Friend");
                Console.WriteLine("C. Love");
                Console.WriteLine("D. Life"); string answer2 = Console.ReadLine().ToUpper();
                if
                    (answer2 == "A") { Console.WriteLine("Correct!"); score++; }
                else
                { Console.WriteLine("Incorrect. The correct answer is A."); }
                Console.WriteLine("3. What is the Maori name for the North Island of New Zealand?"); Console.WriteLine("A. Te Waipounamu");
                Console.WriteLine("B. Rakiura");
                Console.WriteLine("C. Aotearoa");
                Console.WriteLine("D. Te Ika-a-Maui"); string answer3 = Console.ReadLine().ToUpper(); if
                    (answer3 == "D") { Console.WriteLine("Correct!"); score++; }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is D.");
                }
                Console.WriteLine("4. What is the Maori name for the haka dance?");
                Console.WriteLine("A. Waiata");
                Console.WriteLine("B. Kapa haka");
                Console.WriteLine("C. Whakatauki");
                Console.WriteLine("D. Wairua"); string answer4 = Console.ReadLine().ToUpper();
                if (answer4 == "B") { Console.WriteLine("Correct!"); score++; }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is B.");
                }
                Console.WriteLine("5. What is the Maori word for goodbye?");
                Console.WriteLine("A. Nau mai"); Console.WriteLine("B. Ka kite ano");
                Console.WriteLine("C. Haere ra"); Console.WriteLine("D. E noho ra");
                string answer5 = Console.ReadLine().ToUpper();
                if (answer5 == "C")
                {
                    Console.WriteLine("Correct!"); score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is C.");
                }
                Console.Clear();
                Console.WriteLine($"your total score out of 5/{score}");

            } while (questioninputExists == false);
           

        }
    }
}