using BookProject.Models;

namespace BookProject.Service.IService
{
    public interface IUserService
    {
        UserNew Authenticate(string username, string password);
        IEnumerable<UserNew> GetAll();
    }
}
