using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebApplication30.Models
{
    public class Shops
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [MaxLength(100)]
        public string ImageFileNAME { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
