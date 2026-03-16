using System;
namespace OOP_Assignment_2_24006979
{
    abstract class GameLevel
    {
        protected int levelNumber; // stores the level number (level 1 = beginner level)
        protected int timeLimit; //stores the time limit allowed to finish the level

        //constructor used to initialize level information
        public GameLevel(int level, int time)
        {
            levelNumber = level;
            timeLimit = time;
        }
        // Method:start level
        public void StartLevel()
        {
            Console.WriteLine("Level " + levelNumber + " started.");
        }

        // Abstract Method: quiz loading
        public abstract void LoadQuiz();
    }
}