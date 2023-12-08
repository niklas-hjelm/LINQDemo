namespace LINQDemo.Data;

public record Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<Product> Cart { get; } = new List<Product>();
}