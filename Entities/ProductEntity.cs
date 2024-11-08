using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProvider.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Size { get; set; }

    [Column(TypeName = "Money")]
    public decimal Price { get; set; }
    public string? Color { get; set; }
    public string? Category { get; set; }
    public string? ProductImage { get; set; } //first in list of images 

    public virtual ICollection<OrderEntity> Orders { get; set; } = [];
}
