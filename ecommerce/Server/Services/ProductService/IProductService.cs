namespace ecommerce.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetAllProductsAsync();
    Task<ServiceResponse<Product>> GetProductByIdAsync(int productId);
    Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
}