using System.ComponentModel.DataAnnotations;

namespace TestWork.DTOs;

public class ProductDto
{
    public Guid Id { get; set; }
    
    [Required]
    public string Title { get; set; } = null!;
    
    [Required]
    public string Description { get; set; } = null!;
    
    [Required]
    public decimal? Price { get; set; }
    
    [Required]
    public int? Stock { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }
}
