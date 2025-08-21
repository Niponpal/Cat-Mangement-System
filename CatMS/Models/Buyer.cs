namespace CatMS.Models
{
    public class Buyer
    {
        public int Id { get; set; }               // Primary Key
        public string FullName { get; set; }      // Buyer Name
        public string Email { get; set; }         // Buyer Email
        public string Phone { get; set; }         // Buyer Contact
        public string Address { get; set; }       // Buyer Location
        public DateTime RegisterDate { get; set; } // Registered date

        // Navigation property: One Buyer → Many Cats
        public ICollection<Cat> Cats { get; set; }
    }
}
