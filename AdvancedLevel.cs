using System;
namespace OOP_Assignment_2_24006979
{
    class AdvancedLevel : GameLevel
    {
        public AdvancedLevel() : base(2, 420)
        {
        }

        public override void LoadQuiz()
        {
            Console.WriteLine("Loading advanced level questions...");
        }
    }
}