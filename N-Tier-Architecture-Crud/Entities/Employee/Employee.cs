using System.ComponentModel.DataAnnotations;

namespace N_Tier_Architecture_Crud.Entities.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
