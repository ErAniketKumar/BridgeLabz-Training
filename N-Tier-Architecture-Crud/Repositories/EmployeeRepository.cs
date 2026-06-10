using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using N_Tier_Architecture_Crud.Data;
using N_Tier_Architecture_Crud.Dtos.Employee;
using N_Tier_Architecture_Crud.Entities.Employee;

namespace N_Tier_Architecture_Crud.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
        }
        public  async Task<Employee> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }


        public async Task<Employee?> UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> DeleteEmployee(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            if(emp==null)
            {
                return null;
            }
            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<Employee?> GetEmployeeByEmail(string email)
        {
            return await _context.Employees
                .FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
