using EmployeeApi.Models;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Authorize] // ✅ Ensure the controller is protected by JWT
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeeController(IEmployeeService service)
    {
        _service = service;
    }

    // ✅ Get All Employees
    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        try
        {
            var employees = await _service.GetEmployees();
            return Ok(employees);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    // ✅ Get Employee by ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployee(int id)
    {
        try
        {
            var employee = await _service.GetEmployeeById(id);
            if (employee == null) return NotFound(new { message = "Employee not found" });

            return Ok(employee);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    // ✅ Create Employee
    [HttpPost]
    public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
    {
        try
        {
            var newEmployee = await _service.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, newEmployee);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    // ✅ Update Employee
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
    {
        try
        {
            var updatedEmployee = await _service.UpdateEmployee(id, employee);
            if (updatedEmployee == null) return NotFound(new { message = "Employee not found" });

            return Ok(updatedEmployee);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }

    // ✅ Delete Employee
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        try
        {
            var result = await _service.DeleteEmployee(id);
            if (!result) return NotFound(new { message = "Employee not found" });

            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }
}
