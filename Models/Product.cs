using System.ComponentModel.DataAnnotations;
using ApiCrud.Enums;
using Swashbuckle.AspNetCore.Annotations;
namespace ApiCrud.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; init; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
