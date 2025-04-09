namespace BlazorApp.Models;

public class Item
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Image { get; set; } = string.Empty;
    public List<SubItem> SubItems { get; set; } = new();
} 