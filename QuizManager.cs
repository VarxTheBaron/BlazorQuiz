public class QuizManager
{
	public Action? OnStateChanged;

	public Dictionary<string, Quiz> Quizzes = [];

	public QuizManager() { }

	public Quiz GetQuiz(int Id)
	{
		return new Quiz();
	}

	public void SubmitAnswer()
	{

	}

}