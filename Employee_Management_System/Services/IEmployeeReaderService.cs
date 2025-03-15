using Employee_Management_System.Models;

namespace Employee_Management_System.Services
{
    public interface IEmployeeReaderService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
    }
}
