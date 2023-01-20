using System.ComponentModel.DataAnnotations;

namespace TestWork.Models;

public class BaseModel
{
    [Key]
    public Guid Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
    
    public DateTime? Deleted { get; set; }
}