using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_MVC.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Column("CategoryName",TypeName ="nvarchar(100)")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public string? ImageName { get; set; }
        public string? ImageContentType { get; set; }

    }
}
