using NewsBlogAPI.Data;
using NewsBlogAPI.Models;

namespace NewsBlogAPI.Helpers
{
    public class UserReposotory : IUserReposotory
    {
        private readonly DataContext _context;

        public UserReposotory(DataContext context)
        {
           _context = context;
        }

        public User CreateUser(User user)
        {
           _context.users.Add(user);
           _context.SaveChanges();
            return user;
        }

        public List<User> getAllUser()
        {
           return _context.users.ToList();
        }

        public User GetByEmail(string email)
        {
            return _context.users.FirstOrDefault(x => x.Email == email);
        }

        public User GetById(int id)
        {
            return _context.users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserById(int id)
        {
           return _context.users.FirstOrDefault(x => x.Id == id);
        }
    }
}
