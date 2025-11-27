using NuGet.Protocol.Plugins;

namespace CatMS.Models
{
    public class Cat
    {
        public int Id { get; set; }             // Primary Key
        public string Name { get; set; }        // Cat Name
        public string Breed { get; set; }       // Breed type
        public int Age { get; set; }            // Age
        public string Gender { get; set; }      // Male / Female
        public decimal Price { get; set; }      // Price
        public string Color { get; set; }       // Color
        public string Description { get; set; } // Details
        public string ImageUrl { get; set; }    // Picture
        public DateTime PostedDate { get; set; }// Date of posting

        // Seller Relation 
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        // Buyer Relation (optional)
        public int? BuyerId { get; set; }       // Nullable for SetNull on delete
        public Buyer Buyer { get; set; }


        public ICollection<Seller> sellers { get; set; }


    }
}

