namespace Wardrobe.BBualdo.Models;

public class Cloth
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public required string Size { get; set; }
    public required string Color { get; set; }
    public required string Brand { get; set; }
    public string? ImagePath { get; set; }
}