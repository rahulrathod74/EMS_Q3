using Employee_Management_System.Models;

namespace Employee_Management_System.Services
{
    public interface IEmployeeWriterService
    {
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(int id, Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
