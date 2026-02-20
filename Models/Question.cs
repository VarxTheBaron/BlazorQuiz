public class Question
{
    public string Id { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public List<string> Answers { get; set; } = [];
    public int CorrectAnswer { get; set; }
    public List<ParticipantAnswer> ParticipantAnswers { get; set; } = [];
    // public int[] VoteCount
    // {
    //     get => {
    //         int[] count = new int[ParticipantAnswers.count];
    //         for (int i = 0; i < ParticipantAnswers.count; i++)
    //         {
    //             count[i] = ParticipantAnswers[i]
    //         }
    //     }
    // }
}