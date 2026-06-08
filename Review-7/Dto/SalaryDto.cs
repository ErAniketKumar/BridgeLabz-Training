using System.ComponentModel.DataAnnotations;

public class UpdateSalaryDto
{
    [Range(1, double.MaxValue)]
    public decimal Salary { get; set; }
}