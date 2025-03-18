using EmployeeApi.Models;

namespace EmployeeApi.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee?> GetEmployeeById(int id);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Employee?> UpdateEmployee(int id, Employee employee);
        Task<bool> DeleteEmployee(int id);
    }
}
