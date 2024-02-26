using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
