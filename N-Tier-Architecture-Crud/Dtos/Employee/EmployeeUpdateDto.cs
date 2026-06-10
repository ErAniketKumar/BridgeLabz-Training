using System.ComponentModel.DataAnnotations;

namespace N_Tier_Architecture_Crud.Dtos.Employee
{
    public class EmployeeUpdateDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Range(18, 60)]
        public int Age { get; set; }

        [Range(18000, 2000000)]
        public decimal Salary { get; set; }
    }
}
