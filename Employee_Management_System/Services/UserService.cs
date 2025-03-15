using Employee_Management_System.Models;

namespace Employee_Management_System.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "password123" }
        };

        public async Task<bool> ValidateUserAsync(string username, string password)
        {
            var user = _users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return user != null;
        }
    }
}
