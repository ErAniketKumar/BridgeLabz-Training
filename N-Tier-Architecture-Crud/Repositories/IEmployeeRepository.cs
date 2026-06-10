using N_Tier_Architecture_Crud.Dtos.Employee;
using N_Tier_Architecture_Crud.Entities.Employee;

namespace N_Tier_Architecture_Crud.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee?> GetEmployeeById(int id);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee?> UpdateEmployee(Employee employee);
        Task<Employee?> DeleteEmployee(int id);
        Task<Employee?> GetEmployeeByEmail(string email);
    }
}
