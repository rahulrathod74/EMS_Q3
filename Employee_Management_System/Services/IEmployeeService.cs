using Employee_Management_System.Models;
using Employee_Management_System.Services;


namespace Employee_Management_System.Services
{
   
    
        public interface IEmployeeService : IEmployeeReaderService, IEmployeeWriterService
    {
            Task<IEnumerable<Employee>> GetAllEmployeesAsync();
            Task<Employee> GetEmployeeByIdAsync(int id);
            Task<Employee> CreateEmployeeAsync(Employee employee);
            Task<Employee> UpdateEmployeeAsync(int id, Employee employee);
            Task<bool> DeleteEmployeeAsync(int id);
        }
}

