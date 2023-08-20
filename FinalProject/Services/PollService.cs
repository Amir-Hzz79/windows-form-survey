using FinalProject.Models;
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
            return _db.Polls.Include(p=>p.Questions).ThenInclude(q=>q.Answers).FirstOrDefault(p=>p.Id==id);
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
            List<Poll> polls = _db.Polls.Include(p=>p.UserAnswers)
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
                polls=_db.Polls.ToList();
            }
            return polls;
        }

        public bool AddUserAnswer(int pollId, int answerId,int userId) 
        {
            try
            {
                UserAnswers userAnswers=new UserAnswers() 
                { 
                    UserId=userId,
                    AnswerId=answerId,
                    PollId=pollId,
                    DateCreated=DateTime.Now.ToShortDateString(),
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
