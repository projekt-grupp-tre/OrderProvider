using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProvider.Entities;

public class OrderEntity
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(CustomerEntity))]
    public int CustomerId { get; set; }
    public string DeliveryMethod { get; set; } = null!;
    public string PaymentMethod { get; set; } = null!;
    public string OrderStatus { get; set; } = null!;
    public string? PromoCode { get; set; }
    public int Quantity { get; set; }
    public DateTime Created {  get; set; }
    public DateTime Updated { get; set; }
    public CustomerEntity Customer { get; set; } = null!;
    public virtual ICollection<ProductEntity> ProductEntities { get; set; } = [];
}
