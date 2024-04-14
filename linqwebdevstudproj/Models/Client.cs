using System.ComponentModel.DataAnnotations;

namespace linqwebdevstudproj.Models;

public class Client
{
    public long Id { get; set; }
    
    public long Code { get; set; }
    
    public int Year { get; set; }
    
    public int MonthNumber { get; set; }
    
    public int ClassesDurationInHours { get; set; }
}