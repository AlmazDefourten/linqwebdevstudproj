namespace linqwebdevstudproj.Models;

public class GasStation
{
    public long Id { get; set; }
    
    public long Cost { get; set; }

    public string Company { get; set; } = "";

    public string Street { get; set; } = "";
    
    public int Mark { get; set; }
}