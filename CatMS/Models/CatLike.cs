namespace CatMS.Models
{
    public class CatLike
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int CatId { get; set; }
    }
}
