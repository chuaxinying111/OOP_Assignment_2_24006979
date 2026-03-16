using System;
using System.Collections.Generic;

namespace OOP_Assignment_2_24006979
{
    // GameManager controls the overall game flow
    // manages menu navigation, levels, quizzes, and timer
    class GameManager
    {
        private Player player;   // object that represents the player
        private Timer timer;     // object used to control time for each level

        // Constructor : initialize the player object when the game starts
        public GameManager()
        {
            player = new Player();   // create player instance
        }

        // Method : display the main menu of the game
        public void ShowMenu()
        {
            Console.WriteLine("=== C# Sea Shark Challenge ===");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            // if player chooses Start Game, go to level selection
            if (choice == 1)
            {
                SelectLevel();
            }
            else
            {
                Console.WriteLine("Game exited.");
            }
        }

        // Method : show the level selection screen
        public void SelectLevel()
        {
            Console.WriteLine("\n=== Select Level ===");
            Console.WriteLine("Keys Found: " + player.CollectedKeys + "/3");

            Console.WriteLine("1. Beginner Level");

            // advanced level is only can only be access if player collected 3 keys(answered 3 ques correctly)
            if (player.CollectedKeys >= 3)
            {
                Console.WriteLine("2. Advanced Level");
            }
            else
            {
                Console.WriteLine("2. Advanced Level (Locked)");
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                StartBeginnerLevel();
            }
            else if (choice == 2 && player.CollectedKeys >= 3)
            {
                StartAdvancedLevel();
            }
            else
            {
                Console.WriteLine("Level is locked!");
            }
        }

        // Method: to start the beginner level
        public void StartBeginnerLevel()
        {
            Console.WriteLine("\n--- Beginner Level ---");

            timer = new Timer(300); // set timer for beginner level (5 minutes)
            timer.Start();

            BeginnerLevel level = new BeginnerLevel(); // create beginner level object
            level.LoadQuiz();

            // list to store beginner level quiz questions
            List<Quiz> quizzes = new List<Quiz>();

            quizzes.Add(new Quiz("Which keyword is used to declare a class in C#?", "A"));
            quizzes.Add(new Quiz("Which keyword is used to create an object?", "B"));
            quizzes.Add(new Quiz("Which keyword hides data in encapsulation?", "C"));

            int questionNumber = 1;

            // loop through all quiz questions
            foreach (Quiz q in quizzes)
            {
                Console.WriteLine("\nQuestion " + questionNumber);
                q.DisplayQuestion();

                // display multiple choice answers
                Console.WriteLine("A. class");
                Console.WriteLine("B. new");
                Console.WriteLine("C. private");
                Console.WriteLine("D. int");

                Console.Write("Your answer: ");
                string answer = Console.ReadLine();

                // check if the answer is correct
                if (q.CheckAnswer(answer))
                {
                    Console.WriteLine("Correct! You collected a key.");
                    player.CollectedKeys++; // increase key count
                }
                else
                {
                    Console.WriteLine("Wrong answer.");
                }

                questionNumber++;
            }

            Console.WriteLine("\nBeginner Level Completed!");
            Console.WriteLine("Keys Collected: " + player.CollectedKeys + "/3");
            Console.WriteLine("Advanced Level Unlocked!");

            // return to level selection after beginner level
            SelectLevel();
        }

        // Method : start the advanced level
        public void StartAdvancedLevel()
        {
            Console.WriteLine("\n--- Advanced Level ---");

            timer = new Timer(420); // set timer for advanced level (7 minutes)
            timer.Start();

            AdvancedLevel level = new AdvancedLevel(); // create advanced level object
            level.LoadQuiz();

            // list of advanced level quiz questions
            List<Quiz> quizzes = new List<Quiz>();

            quizzes.Add(new Quiz("Which symbol is used for inheritance in C#?", "B"));
            quizzes.Add(new Quiz("Which access modifier hides data inside a class?", "A"));
            quizzes.Add(new Quiz("Which keyword allows a class to inherit from another class in C#?", "D"));

            int questionNumber = 1;

            // loop through advanced quiz questions
            foreach (Quiz q in quizzes)
            {
                Console.WriteLine("\nQuestion " + questionNumber);
                q.DisplayQuestion();

                Console.WriteLine("A. private");
                Console.WriteLine("B. :");
                Console.WriteLine("C. inherits");
                Console.WriteLine("D. public");

                Console.Write("Your answer: ");
                string answer = Console.ReadLine();

                if (q.CheckAnswer(answer))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong answer.");
                }

                questionNumber++;
            }

            // final completion message after finishing advanced level
            Console.WriteLine("\nAdvanced Level Completed!");
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You completed the C# Sea Shark Challenge!");

            Console.WriteLine("\n1. Play Again");
            Console.WriteLine("2. Exit Game");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                ShowMenu(); // restart the game
            }
            else
            {
                Console.WriteLine("Game finished.");
            }
        }
    }
}