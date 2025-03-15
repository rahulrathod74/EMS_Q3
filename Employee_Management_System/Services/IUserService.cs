namespace Employee_Management_System.Services
{
    public interface IUserService
    {
        Task<bool> ValidateUserAsync(string username, string password);
    }
}
