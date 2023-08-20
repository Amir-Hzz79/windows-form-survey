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

        public bool Add(User user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(User user)
        {
            try
            {
                _db.Users.Update(user);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
