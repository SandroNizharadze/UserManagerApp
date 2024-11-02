using Practice.Models;

namespace Practice
{
    public static class Game
    {
        public static void Start(Quiz quiz)
        {
            int score = 0;

            Console.WriteLine($"Quiz: {quiz.Name}");
            foreach (var question in quiz.Questions)
            {
                int count = 1;
                Console.WriteLine($"\n{count}. {question.QuestionText}");

                var shuffledAnswers = Shuffle(question.Answers);
                for (int i = 0; i < shuffledAnswers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {shuffledAnswers[i].AnswerText}");
                }

                Console.Write("Your Answer: ");
                if (int.TryParse(Console.ReadLine(), out int userAnswerIndex))
                {
                    if (shuffledAnswers[userAnswerIndex - 1].IsCorrect)
                    {
                        score++;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine($"\nYour result: {score}/{quiz.Questions.Count}");
        }

        private static List<Answer> Shuffle(List<Answer> answers)
        {
            return answers.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}