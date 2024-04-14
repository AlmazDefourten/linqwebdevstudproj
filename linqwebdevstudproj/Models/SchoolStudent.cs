namespace linqwebdevstudproj.Models;

public class SchoolStudent
{
    public long Id { get; set; }
    
    public int Class { get; set; }

    public string LastName { get; set; } = "";

    public string Initials { get; set; } = "";

    public string Subject { get; set; } = "";
    
    public int Mark { get; set; }
}