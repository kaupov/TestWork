using System.ComponentModel.DataAnnotations;

namespace TestWork.Models;

public class Product : BaseModel
{
    [Required]
    public string Title { get; set; } = null!;
    
    [Required]
    public string Description { get; set; } = null!;
    
    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public int Stock { get; set; }
}