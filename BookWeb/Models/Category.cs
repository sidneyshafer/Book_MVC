using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Category Name field must be less than 30 characters.")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Display Order field is required.")]
        [Range(1, 100, ErrorMessage = "The Display Order field must be between 1-100.")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
