using N_Tier_Architecture_Crud.Dtos.Employee;
using N_Tier_Architecture_Crud.Entities.Employee;

namespace N_Tier_Architecture_Crud.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponseDto>> GetEmployees();
        Task<EmployeeResponseDto?> GetEmployeeById(int id);
        Task<EmployeeResponseDto?> AddEmployee(EmployeeCreateDto dto);
        Task<EmployeeResponseDto?> UpdateEmployee(int id, EmployeeUpdateDto dto);
        Task<EmployeeResponseDto?> DeleteEmployee(int id);

    }
}
