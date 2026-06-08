using Review_7.Dto;
using Review_7.Entities;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();
    Task<Employee?> GetByIdAsync(int id);
    Task<Employee> CreateAsync(CreateEmployeeDto dto);
    Task<Employee?> UpdateAsync(
        int id,
        UpdateEmployeeDto dto);

    Task<Employee?> UpdateSalaryAsync(
        int id,
        decimal salary);

    Task<bool> DeleteAsync(int id);
}