namespace linqwebdevstudproj.Models;

public class Purchase
{
   public long Id { get; set; }
   
   public string Article { get; set; }
   
   public Buyer Buyer { get; set; }
   
   public long BuyerId { get; set; }
   
   public string ShopName { get; set; }
}