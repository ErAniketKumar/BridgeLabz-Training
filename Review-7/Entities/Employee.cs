using System.ComponentModel.DataAnnotations;

namespace Review_7.Entities
{
    public class Employee
    {
        //FieldTypeIdIntegerNameStringEmailStringDepartmentStringSalaryDecimal
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Department {  get; set; } = string.Empty;

        public decimal Salary { get; set; } = 0.0m;

    }
}
