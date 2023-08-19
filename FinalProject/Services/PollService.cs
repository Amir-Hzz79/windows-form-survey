using FinalProject.Models;

namespace FinalProject.Services
{
    public class PollService
    {
        MyDbContext _db;
        public PollService(MyDbContext dbContext)
        {
            _db = dbContext;
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
