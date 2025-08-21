namespace CatMS.Models
{
    public class Seller
    {
        public int Id { get; set; }               // Primary Key
        public string FullName { get; set; }      // Seller Name
        public string Email { get; set; }         // Contact Email
        public string Phone { get; set; }         // Phone Number
        public string Address { get; set; }       // Seller Location
        public DateTime JoinDate { get; set; }    // When seller joined

        // Navigation property: One Seller → Many Cats
        public ICollection<Cat> Cats { get; set; }

    }
}
