using System;
namespace OOP_Assignment_2_24006979
{
    class Timer
    {
        private int remainingTime;//stores the remaining time for the level

        //constructor: initialize timer with time limit for the level
        public Timer(int time)
        {
            remainingTime = time;
        }

        // Method : start timer 
        public void Start()
        {
            Console.WriteLine("Timer started: " + remainingTime + " seconds.");
        }

        // Method : time up message 
        public void TimeUp()
        {
            Console.WriteLine("Time's Up!");
        }
    }
}