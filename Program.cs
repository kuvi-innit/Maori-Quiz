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
                    levelExists = true;
                }

                {
                    levelExists = (true);
                }
            } while (levelExists == false);
            Console.Clear();
            Console.WriteLine($"You have chosen level {level}!");
            Console.WriteLine("\nGood luck and have fun!");
            Console.WriteLine("Please press enter to continue to the quiz");

            //end of Level method 
            int score = 0;
            string questioninput;
            bool questioninputExists = false;
            do
            {
                questioninput = Console.ReadLine();
                if (questioninput == "A")
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


                if (level == "1")
                        Console.WriteLine("Welcome to the Maori Quiz!");
                        Console.WriteLine("Difficulty Level 1 - Easy");
                        Console.WriteLine("Answer the following questions by selecting the correct option:\n");



                        string[] questions = new string[] { "1. What is the Maori word for hello?\nA. Kia ora\n B. Haere mai\n C. Ka kite ano \n D. Nau mai ",
                            "2. What is the meaning of the word 'whanau'?\nA.Family\n B. Friend\n C. Love\n D.Life",
                            "3. What is the Maori name for New Zealand?",
                            "4. What is the Maori name for the haka dance?",
                            "5. What is the Maori word for goodbye?"
                        };

                        string[] answers = new string[] { "A", "B", "C" };

                        /* string[] options = {
                         {"A. Kia ora", "B. Haere mai", "C. Ka kite ano", "D. Nau mai "},
                         {"A. Family", "B. Friend", "C. Love", "D. Life",},
                         {"A. Te Waipounamu", "B. Rakiura", "C. Aotearoa", "D. Te Ika-a-Maui"},
                         {"A.  Waiata", "B. Kapa haka", "C. Whakatauki", "D.  Wairua"},
                         {"A.  Nau mai", "B.  Ka kite ano", "C. Haere ra", "D. Kia ora"}
                           };*/




                        /*Console.WriteLine("Answer the following questions by typing the letter of the correct answer.");
                        Console.WriteLine("1. What is the Maori word for hello?");
                        Console.WriteLine("A. Kia ora");
                        Console.WriteLine("B. Haere mai");
                        Console.WriteLine("C. Ka kite ano");
                        Console.WriteLine("D. Nau mai");*/
                        for (int i = 0; i < questions.Length; i++)
                        {
                            Console.WriteLine(questions[i]);


                            string answer1 = Console.ReadLine().ToUpper();
                            if (answer1.Equals(answers[i]))
                            {
                                Console.WriteLine("Correct!");
                                score++;
                            }

                            else
                            {
                                Console.WriteLine($"Incorrect. The correct answer is {answers[i]}");
                            }
                        }
            }