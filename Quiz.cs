using System;

namespace OOP_Assignment_2_24006979
{
    class Quiz
    {
        private string question;//stores the quiz question
        private string correctAnswer;//stores the correct answer for the quiz question

        //Constrctor:initialize quiz question and answer
        public Quiz(string q, string answer)
        {
            question = q;
            correctAnswer = answer;
        }

        // Method:show question
        public void DisplayQuestion()
        {
            Console.WriteLine(question);
        }

        // check if answer is correct
        public bool CheckAnswer(string answer)
        {
            if (answer.ToUpper() == correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method:show hint
        public void ShowHint()
        {
            Console.WriteLine("Hint: Think about basic C# keywords.");
        }
    }
}