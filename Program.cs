namespace Practice;

public class Program
{
    public static void Main()
    {
        QuizManager.Run();
        var quiz = QuizManager.GetQuiz();

        Game.Start(quiz);
    }
    
}