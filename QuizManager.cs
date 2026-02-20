public class QuizManager
{
	public Action? OnStateChanged;


	public QuizManager() { }

	public Quiz GetQuiz(int Id)
	{
		return new Quiz();
	}

	public void SubmitAnswer()
	{

	}

	public Dictionary<string, Quiz> Quizzes = new Dictionary<string, Quiz>()
	   {
		   {
			   "math", new Quiz()
			   {
				   Id = "math",
				   Title = "Basic Math Quiz",
				   Questions =
				   [
					   new Question()
					   {
						   Id = "math1",
						   Text = "What is 2 + 2?",
						   Answers = ["3", "4", "5", "6"],
						   CorrectAnswer = 1
					   },
					   new Question()
					   {
						   Id = "math2",
						   Text = "What is 5 * 3?",
						   Answers = ["8", "15", "10", "20"],
						   CorrectAnswer = 1
					   },
					   new Question()
					   {
						   Id = "math3",
						   Text = "What is the square root of 16?",
						   Answers = ["2", "4", "8", "16"],
						   CorrectAnswer = 1
					   }
				   ],
				   CurrentQuestionIndex = 0
			   }
		   },
		   {
			   "science", new Quiz()
			   {
				   Id = "science",
				   Title = "Basic Science Quiz",
				   Questions =
				   [
					   new Question()
					   {
						   Id = "science1",
						   Text = "What planet is known as the Red Planet?",
						   Answers = ["Earth", "Mars", "Jupiter", "Venus"],
						   CorrectAnswer = 1
					   },
					   new Question()
					   {
						   Id = "science2",
						   Text = "What is H2O?",
						   Answers = ["Oxygen", "Hydrogen", "Water", "Carbon Dioxide"],
						   CorrectAnswer = 2
					   },
					   new Question()
					   {
						   Id = "science3",
						   Text = "What gas do plants absorb from the atmosphere?",
						   Answers = ["Nitrogen", "Oxygen", "Carbon Dioxide", "Helium"],
						   CorrectAnswer = 2
					   }
				   ],
				   CurrentQuestionIndex = 0
			   }
		   },
		   {
			   "history", new Quiz()
			   {
				   Id = "history",
				   Title = "Basic History Quiz",
				   Questions =
				   [
					   new Question()
					   {
						   Id = "history1",
						   Text = "Who was the first President of the United States?",
						   Answers = ["Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams"],
						   CorrectAnswer = 1
					   },
					   new Question()
					   {
						   Id = "history2",
						   Text = "In which year did World War II end?",
						   Answers = ["1942", "1945", "1950", "1939"],
						   CorrectAnswer = 1
					   },
					   new Question()
					   {
						   Id = "history3",
						   Text = "Which ancient civilization built the pyramids?",
						   Answers = ["Romans", "Greeks", "Egyptians", "Aztecs"],
						   CorrectAnswer = 2
					   }
				   ],
				   CurrentQuestionIndex = 0
			   }
		   }
	   };
}