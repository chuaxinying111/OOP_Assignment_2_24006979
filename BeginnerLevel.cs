using System;
namespace OOP_Assignment_2_24006979
{
    // Inheritance : BeginnerLevel class inherits from GameLevel
    
    class BeginnerLevel : GameLevel
    {
        // base(1, 300) means level number = 1 and time limit = 300 seconds
        public BeginnerLevel() : base(1, 300)
        {
        }

        // Method : loads the quiz questions for the beginner level
        // overrides the abstract method from GameLevel
        public override void LoadQuiz()
        {
            Console.WriteLine("Loading beginner level questions...");
        }
    }
}