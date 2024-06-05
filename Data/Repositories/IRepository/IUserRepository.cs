using BookProject.Models;

namespace BookProject.Data.Repositories.IRepository
{
    public interface IUserRepository
    {
        List<User> GetAllUsersInMemory();
        List<User> GetAllUsersFromDatabase();
        User GetUserById(int id);
        Role GetRoleById(int id);
        void AddUser(User user);
        List<User> GetUsersOrderedByUsername();
        List<IGrouping<string, User>> GetUsersGroupedByRole();
        List<UserRoleDto> GetUsersWithRoles();
    }
}
