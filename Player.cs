using System;
namespace OOP_Assignment_2_24006979
{
    class Player
    {
        private int currentPosition;
        private int collectedKeys;

        // Method : property for keys
        public int CollectedKeys
        {
            get { return collectedKeys; }
            set { collectedKeys = value; }
        }

        public Player()
        {
            currentPosition = 0;
            collectedKeys = 0;
        }

        // Method : player moves right
        public void MoveRight()
        {
            currentPosition++;
            Console.WriteLine("Player moves forward.");
        }

        // Method : player moves left
        public void MoveLeft()
        {
            currentPosition--;
            Console.WriteLine("Player moves back.");
        }

        // Method : jump action
        public void Jump()
        {
            Console.WriteLine("Player jumps.");
        }

        // Method : reset position if fail
        public void ResetPosition()
        {
            currentPosition = 0;
            Console.WriteLine("Player returned to start.");
        }
    }
}