using Microsoft.AspNetCore.Mvc;
using Employee_Management_System.Models;
using Employee_Management_System.Services;
using Microsoft.AspNetCore.Authorization;

namespace Employee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeReaderService _employeeReaderService;
        private readonly IEmployeeWriterService _employeeWriterService;
        private readonly IEmployeeService _employeeService;

        // ✅ Combined Constructor - Single constructor with all dependencies
        public EmployeeController(
            IEmployeeReaderService employeeReaderService,
            IEmployeeWriterService employeeWriterService,
            IEmployeeService employeeService)
        {
            _employeeReaderService = employeeReaderService;
            _employeeWriterService = employeeWriterService;
            _employeeService = employeeService;
        }

        // ✅ GET /api/employees → Fetch all employees
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeReaderService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        // ✅ GET /api/employees/{id} → Fetch employee by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeReaderService.GetEmployeeByIdAsync(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        // ✅ POST /api/employees → Create a new employee
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var createdEmployee = await _employeeWriterService.CreateEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = createdEmployee.Id }, createdEmployee);
        }

        // ✅ PUT /api/employees/{id} → Update an existing employee
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (id != employee.Id) return BadRequest("Employee ID mismatch");

            var updatedEmployee = await _employeeService.UpdateEmployeeAsync(id, employee);
            if (updatedEmployee == null) return NotFound($"Employee with Id = {id} not found");

            return NoContent(); // 204 No Content
        }

        // ✅ DELETE /api/employees/{id} → Delete employee by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var success = await _employeeWriterService.DeleteEmployeeAsync(id);
            if (!success) return NotFound();
            return Ok($"Employee with Id = {id} deleted");
        }
    }
}
