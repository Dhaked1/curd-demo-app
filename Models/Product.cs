using System.ComponentModel.DataAnnotations;

namespace CurdDemoApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public string? ImagePath { get; set; }
    }
}
