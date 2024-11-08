using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProvider.Entities;

public class CustomerEntity
{
    public int Id { get; set; }

    [Required]
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;
    [Required]
    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
}
