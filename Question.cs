namespace Practice.Models
{
    public class Question : BaseClass
    {
        public Question(string questionText, List<Answer> answers) : base()
        {
            QuestionText = questionText;
            Answers = answers;
        }

        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }

        public void AddAnswer(Answer answer)
        {
            Answers.Add(answer);
        }

        public void RemoveAnswer(Answer answer)
        {
            Answers.Remove(answer);
        }

        public string GetQuestionContent()
        {
            var content = $"{QuestionText}\n";
            for (int i = 0; i < Answers.Count; i++)
            {
                content += $"Answer {i + 1}: {Answers[i].AnswerText}\n";
            }
            return content;
        }
    }
}