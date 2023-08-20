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

        public List<Poll> GetAll(bool includeQuestion)
        {
            List<Poll> polls = _db.Polls.Include(p => p.UserAnswers).Include(p => p.Questions).ThenInclude(q => q.Answers).ToList();

            return polls;
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
