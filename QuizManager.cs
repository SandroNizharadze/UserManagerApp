using Practice.Models;

namespace Practice
{
    public static class QuizManager
    {
        public static Quiz quiz;

        public static void Run()
        {
            Console.Write("Quiz name: ");
            quiz = new Quiz(Console.ReadLine());
            
            Console.Write("Question count: ");
            int questionCount = int.Parse(Console.ReadLine());

            Console.Write("Answer per question: ");
            int answerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("*Reminder - Correct answer first");

            for (int i = 1; i <= questionCount; i++)
            {
                Console.Write($"\nQuestion {i}: ");
                string questionText = Console.ReadLine();

                var question = new Question(questionText, new List<Answer>());
                
                for (int j = 1; j <= answerCount; j++)
                {
                    Console.Write($"Answer {j}: ");
                    string answerText = Console.ReadLine();

                    bool isCorrect = (j == 1);
                    question.AddAnswer(new Answer(answerText, isCorrect));
                }
                quiz.AddQuestion(question);
            }

            Console.WriteLine(quiz.GetQuizContent());
        }

        public static Quiz GetQuiz()
        {
            return quiz;
        }
    }
}