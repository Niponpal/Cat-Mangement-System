namespace CatMS.Models
{
    public class EditSellerRequest
    {
        public int Id { get; set; }               // Primary Key
        public string FullName { get; set; }      // Seller Name
        public string Email { get; set; }         // Contact Email
        public string Phone { get; set; }         // Phone Number
        public string Address { get; set; }       // Seller Location
        public DateTime JoinDate { get; set; }    // When seller joined
    }
}
