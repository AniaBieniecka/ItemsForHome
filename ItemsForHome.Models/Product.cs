using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemsForHomeStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
