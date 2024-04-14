namespace linqwebdevstudproj.Models;

public class DiscountInfo
{
    public long Id { get; set; }
    
    public Buyer Buyer { get; set; }
    
    public long BuyerId { get; set; }
    
    public string ShopName { get; set; }
    
    public long DiscountInPercents { get; set; }
}