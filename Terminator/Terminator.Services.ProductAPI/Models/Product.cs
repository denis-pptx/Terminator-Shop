using System.ComponentModel.DataAnnotations;

namespace Terminator.Services.ProductAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;

    [Range(1, 1000)]
    public double Price { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
