using CRUD_APP_DOTNET.Data;
using CRUD_APP_DOTNET.Models;
using CRUD_APP_DOTNET.Models.Entities;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_APP_DOTNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var allEmployees = _context.Employees.ToList();

            return Ok(allEmployees);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };

            _context.Employees.Add(employeeEntity);
            _context.SaveChanges();

            return Ok(_context.Employees);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAEmployee(Guid id)
        {
            var employee = _context.Employees.Find(id);
            return Ok(employee);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmoloyeeDto updateEmoloyeeDto)
        {
            var updatedEmployee = _context.Employees.Find(id);

            if(updatedEmployee==null)
            {
                return NotFound();
            }
            updatedEmployee.Name = updateEmoloyeeDto.Name;
            updatedEmployee.Email = updateEmoloyeeDto.Email;
            updatedEmployee.Phone = updateEmoloyeeDto.Phone;
            updatedEmployee.Salary = updateEmoloyeeDto.Salary;

            _context.SaveChanges();
            return Ok(updatedEmployee);

        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var tobeDelete = _context.Employees.Find(id);
            if(tobeDelete==null)
            {
                return NotFound();
            }

            _context.Employees.Remove(tobeDelete);
            _context.SaveChanges();

            return Ok(tobeDelete);
        }
    }
}
