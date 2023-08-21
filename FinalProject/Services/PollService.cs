using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Services
{
	public class PollService
	{
		MyDbContext _db;
		public PollService(MyDbContext dbContext)
		{
			_db = dbContext;
		}

		public Poll Get(int id)
		{
			return _db.Polls.Include(p => p.Questions).ThenInclude(q => q.Answers).FirstOrDefault(p => p.Id == id);
		}

		public Poll Get(int pollId, int userId)
		{
			return _db.Polls
			.Include(p => p.Questions)
				.ThenInclude(q => q.Answers)
			.Include(p => p.UserAnswers)
				.ThenInclude(ua => ua.User)
			.Include(p => p.UserAnswers)
				.ThenInclude(ua => ua.Answer)
			.FirstOrDefault(p => p.Id == pollId && p.UserAnswers.Any(ua => ua.UserId == userId));
		}

		public List<AnswerPercent> GetAnswerPercent(int pollId)
		{
			Poll poll = _db.Polls.Include(p => p.UserAnswers)
				.ThenInclude(ua=>ua.Answer)
				.Include(p => p.Questions)
				.FirstOrDefault(p => p.Id == pollId);


			List<AnswersCount> a = poll.UserAnswers.GroupBy(ua => ua.AnswerId).Select(g => new AnswersCount
			{
				AnswerId = g.Key,
				Count = g.Count()
			}).ToList();

			List<QuestionsAnswerCount> c =poll.Questions.Select(q => new QuestionsAnswerCount
			{
				QuestionId = q.Id,
				Count = poll.UserAnswers.Count(ua => ua.Answer.QuestionID == q.Id)
			}).ToList();

			List<AnswerPercent> answerPercentages = new List<AnswerPercent>();

			foreach (var item in a)
			{
				int questionId = _db.Answers.Find(item.AnswerId).QuestionID;
				answerPercentages.Add(new AnswerPercent()
				{
					AnswerId=item.AnswerId,
					QuestionId=questionId,
					Percentage= item.Count * 100 / c.Where(a => a.QuestionId == questionId).FirstOrDefault().Count,
				});
			}

			return answerPercentages;
		}

		public List<Poll> GetAllUnAvaiable(int userId)
		{
			List<Poll> polls = _db.Polls.Include(p => p.UserAnswers)
				.Where(p => p.UserAnswers.Any(ua => ua.UserId == userId))
				.ToList();
			return polls;
		}

		public List<Poll> GetAllAvaiable(int userId)
		{
			List<Poll> polls = _db.Polls.Include(p => p.UserAnswers)
				.Where(p => !p.UserAnswers.Any(ua => ua.UserId == userId))
				.ToList();
			return polls;
		}

		public List<Poll> GetAll(bool includeQuestion)
		{
			List<Poll> polls;
			if (includeQuestion)
			{
				polls = _db.Polls.Include(p => p.UserAnswers).Include(p => p.Questions).ThenInclude(q => q.Answers).ToList();
			}
			else
			{
				polls = _db.Polls.ToList();
			}
			return polls;
		}

		public bool AddUserAnswer(int pollId, int answerId, int userId)
		{
			try
			{
				UserAnswers userAnswers = new UserAnswers()
				{
					UserId = userId,
					AnswerId = answerId,
					PollId = pollId,
					DateCreated = DateTime.Now.ToShortDateString(),
				};

				_db.UserAnswers.Add(userAnswers);
				_db.SaveChanges();

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool Add(Poll poll)
		{
			try
			{
				_db.Polls.Add(poll);
				_db.SaveChanges();

				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
