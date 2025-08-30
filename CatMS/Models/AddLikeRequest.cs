namespace CatMS.Models
{
    public class AddLikeRequest
    {
           public int CatId  { get; set; }
           public Guid UserId { get; set; }
    }
}
