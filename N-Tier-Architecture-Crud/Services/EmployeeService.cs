using N_Tier_Architecture_Crud.Dtos.Employee;
using N_Tier_Architecture_Crud.Entities.Employee;
using N_Tier_Architecture_Crud.Repositories;

namespace N_Tier_Architecture_Crud.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _empRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._empRepository = employeeRepository;
        }

        private EmployeeResponseDto MapToResponse(Employee employee)
        {
            return new EmployeeResponseDto
            {
                Name = employee.Name,
                Email = employee.Email,
                Age = employee.Age,
                Salary = employee.Salary
            };
        }

        public async Task<EmployeeResponseDto?> AddEmployee(EmployeeCreateDto dto)
        {
            var existingEmployee =
                await _empRepository.GetEmployeeByEmail(dto.Email);

            if (existingEmployee != null)
            {
                return null;
            }

            var emp = new Employee
            {
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Salary = dto.Salary
            };

            var createdEmployee =  await _empRepository.AddEmployee(emp);
            return MapToResponse(createdEmployee);
        }

        public async Task<EmployeeResponseDto?> DeleteEmployee(
     int id)
        {
            if (id <= 0)
            {
                return null;
            }

            var deletedEmployee =
                await _empRepository.DeleteEmployee(id);

            if (deletedEmployee == null)
            {
                return null;
            }

            return MapToResponse(deletedEmployee);
        }

        public async Task<EmployeeResponseDto?> GetEmployeeById(int id)
        {
            if (id <= 0) return null;
                var employee = await _empRepository.GetEmployeeById(id);
            if (employee==null)
            {
                return null;
            }

            return MapToResponse(employee);
        }

        public async Task<List<EmployeeResponseDto>> GetEmployees()
        {
            var employees = await _empRepository.GetEmployees();

            return employees
                .Select(MapToResponse)
                .ToList();
        }

        public async Task<EmployeeResponseDto?> UpdateEmployee(
    int id,
    EmployeeUpdateDto dto)
        {
            var employee =
                await _empRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return null;
            }

            employee.Name = dto.Name;
            employee.Age = dto.Age;
            employee.Salary = dto.Salary;

            var updatedEmployee =
                await _empRepository.UpdateEmployee(employee);

            return MapToResponse(updatedEmployee);
        }
    }
}
