namespace CatMS.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Cat> Cats { get; set; }
        public IEnumerable<Seller> sellers { get; set; }
    }
}
