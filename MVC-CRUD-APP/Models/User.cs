using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_APP.Models
{
    public class User
    {
       [Key]
       public int Id { get; set; }
       public required string UserName { get; set; }
       public required string Email { get; set; }
       public required string Password { get; set; }

    }
}
