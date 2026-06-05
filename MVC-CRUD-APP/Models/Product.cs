using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_APP.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0.00m;
        public string Color { get; set; } = "";

    }
}
