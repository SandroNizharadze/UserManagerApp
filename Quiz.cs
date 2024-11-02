using Practice.Models;

namespace Practice
{
    public class Quiz
    {
        public Quiz(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }

        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public string GetQuizContent()
        {

            var content = ("\n-------------------------------------\n");
            content += $"Quiz: {Name}\n";

            foreach (var question in Questions)
            {
                content += $"\nQuestion text: {question.QuestionText}\n";
                foreach (var answer in question.Answers)
                {
                    content += $"Answer text: {answer.AnswerText}\n";
                }
            }
            
            content += "\n-------------------------------------\n";
            return content;
        }
        
    }
}