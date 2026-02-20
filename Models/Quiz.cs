public class Quiz
{
    public string Title { get; set; } = string.Empty;
    public List<Question> Questions = [];
    public int CurrentQuestionIndex { get; set; }
}