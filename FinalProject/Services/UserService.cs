using FinalProject.Models;

namespace FinalProject.Services
{
    public class UserService
    {
        MyDbContext _db;
        public UserService(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public bool Login(string username, string password)
        {
            try
            {
                User user = _db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    AppData.User = user;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
