using System.ComponentModel.DataAnnotations;

namespace CatMS.Models
{
    public class CatDetailsViewModel
    {
        public int Id { get; set; }  // Optional, usually DB generates

        [Required, StringLength(100)]
        public string Name { get; set; }        // Cat Name

        [StringLength(50)]
        public string? Breed { get; set; }      // Breed type

        [Range(0, 25)]
        public int Age { get; set; }            // Age in years

        [Required]
        public string Gender { get; set; }      // Male / Female

        [Range(0, 100000)]
        public decimal Price { get; set; }      // Price

        [StringLength(30)]
        public string? Color { get; set; }      // Color

        [StringLength(500)]
        public string? Description { get; set; } // Details

        public string? ImageUrl { get; set; }   // Picture

        public DateTime PostedDate { get; set; } = DateTime.Now; // Default now

        // Relations (just IDs in request)
        [Required]
        public int SellerId { get; set; }       // Link to Seller

        public int? BuyerId { get; set; }       // Nullable (if not sold yet)

        // Optional: Tags / Extra Info (if needed in request)
        public List<string> seller { get; set; } = new();
    }
}
