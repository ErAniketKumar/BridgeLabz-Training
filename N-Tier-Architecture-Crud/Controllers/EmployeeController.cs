using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N_Tier_Architecture_Crud.Dtos.Employee;
using N_Tier_Architecture_Crud.Entities.Employee;
using N_Tier_Architecture_Crud.Services;

namespace N_Tier_Architecture_Crud.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _empService;
        public EmployeeController(IEmployeeService empService)
        {
            _empService = empService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateDto dto)
        {
            var emp = await _empService.AddEmployee(dto);
            if (emp == null)
            {
                return BadRequest("Employee already exists");
            }

            return Ok(emp);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var emp = await _empService.GetEmployees();
            return Ok(emp);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var emp =  await _empService.GetEmployeeById(id);
            if(emp==null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeUpdateDto dto)
        { 
            var employee = await _empService.UpdateEmployee(id, dto);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp =  await _empService.DeleteEmployee(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

    }
}
