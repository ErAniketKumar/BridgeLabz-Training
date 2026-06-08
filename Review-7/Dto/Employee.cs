using System.ComponentModel.DataAnnotations;

namespace Review_7.Dto
{
    public class CreateEmployeeDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        [Range(1, double.MaxValue)]
        public decimal Salary { get; set; }
    }

    public class UpdateEmployeeDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        [Range(1, double.MaxValue)]
        public decimal Salary { get; set; }
    }
}