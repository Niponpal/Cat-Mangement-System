namespace CatMS.Models
{
    public class CatComment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CattId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
