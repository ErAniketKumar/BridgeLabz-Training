using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPCOREWEB.Models
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public double Price { get; set; }
        public int Pages { get; set; }
        public bool IsPublished { get; set; } = false;
        public DateTime PublishedDate { get; set; } = DateTime.Now;
    }
}
