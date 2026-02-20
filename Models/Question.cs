public class Question
{
    public string Id { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public List<string> Answers { get; set; } = [];
    public int CorrectAnswer { get; set; }
    public List<ParticipantAnswer> ParticipantAnswers { get; set; } = [];
    public int[] VoteCount
    {
        get
        {
            int[] count = [Answers.Count];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = ParticipantAnswers.Count(pa => pa.AnswerIndex == i);
            }
            return count;
        }
    }
}