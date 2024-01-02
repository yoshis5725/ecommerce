using ecommerce.Shared;

namespace ecommerce.Client.Services.ProductService;

public interface IProductService
{
    event Action ProductsChanged;
    List<Product>? Products { get; set; }
    Task GetProducts(string? category = null);
    Task <ServiceResponse<Product>> GetProductById(int id);
}