using NewsBlogAPI.Models;

namespace NewsBlogAPI.Helpers
{
    public interface IUserReposotory
    {
        List<User> getAllUser();
        User GetUserById(int id);
        User CreateUser(User user);
        User GetByEmail(string email);
        User GetById(int id);
    }
}
