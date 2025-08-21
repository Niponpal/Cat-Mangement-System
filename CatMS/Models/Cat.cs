namespace CatMS.Models
{
    public class Cat
    {
        public int Id { get; set; }             // Primary Key
        public string Name { get; set; }           // Cat Name
        public string Breed { get; set; }          // Breed type
        public int Age { get; set; }               // Age in months/years
        public string Gender { get; set; }         // Male / Female
        public decimal Price { get; set; }         // Price for selling
        public string Color { get; set; }          // Color of Cat
        public string Description { get; set; }    // Details
        public string ImageUrl { get; set; }       // Picture of Cat
        public DateTime PostedDate { get; set; }   // Date of posting
     
    }
}
