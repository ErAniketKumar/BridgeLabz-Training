using System.ComponentModel.DataAnnotations;

namespace N_Tier_Architecture_Crud.Dtos.Employee
{
    public class EmployeeResponseDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
