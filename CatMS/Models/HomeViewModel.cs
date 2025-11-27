namespace CatMS.Models;

public class HomeViewModel
{
    // Cat info
    public int CatId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public decimal Price { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PostedDate { get; set; }

    // Seller info
    public int SellerId { get; set; }
    public string SellerName { get; set; }
    public string SellerEmail { get; set; }
    public string SellerPhone { get; set; }
    public string SellerAddress { get; set; }
}
