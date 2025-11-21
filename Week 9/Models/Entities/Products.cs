using System.ComponentModel.DataAnnotations;

namespace HEHE.Models.Entities
{
    public class Products
    {
        public int Id { get; set; }


        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, 1000)]
        public decimal Price { get; set; }

        [StringLength(200)]
        public string ?Description { get; set; }

         
    }
}
