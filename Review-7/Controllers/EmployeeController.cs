using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Review_7.Data;
using Review_7.Dto;
using Review_7.Entities;

namespace Review_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto dto)
        {
            if(dto==null)
            {
                return BadRequest("details cnnot be empty");
            }

            var emp = new Employee
            {
                Name = dto.Name,
                Email = dto.Email,
                Department = dto.Department,
                Salary = dto.Salary
            };

            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();

            return Ok(emp);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeById(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);

            if (employee == null)
            {
                return BadRequest("Not found!");
            }

            return Ok(employee);
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployeeById(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);

            if (employee == null)
            {
                return BadRequest("Not found!");
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEmployee(
    int id,
    UpdateEmployeeDto dto)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            employee.Name = dto.Name;
            employee.Email = dto.Email;
            employee.Department = dto.Department;
            employee.Salary = dto.Salary;

            await _context.SaveChangesAsync();

            return Ok(employee);
        }



        [HttpPatch("{id:int}/salary")]
        public async Task<IActionResult> UpdateSalary(
    int id,
    UpdateSalaryDto dto)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            employee.Salary = dto.Salary;

            await _context.SaveChangesAsync();

            return Ok(employee);
        }



        [HttpGet]
        public async Task<IActionResult> GetEmployees([FromQuery] string? department)
        {
            IQueryable<Employee> query =
                _context.Employees;

            if (!string.IsNullOrEmpty(department))
            {
                query = query.Where(x =>
                    x.Department == department);
            }

            var employees = await query.ToListAsync();

            return Ok(employees);
        }

    }
}
