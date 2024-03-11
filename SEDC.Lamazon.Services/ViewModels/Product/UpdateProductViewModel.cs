namespace SEDC.Lamazon.Services.ViewModels.Product;

public class UpdateProductViewModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public decimal Price { get; set; }

    public int ProductCategoryId { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }

    public DateTime DateTime { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }
}
