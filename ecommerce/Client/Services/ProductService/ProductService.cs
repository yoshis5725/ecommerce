
using System.Net.Http.Json;

namespace ecommerce.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    public event Action? ProductsChanged;
    public List<Product>? Products { get; set; } = new ();


    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    
    public async Task GetProducts(string? categoryUrl = null)
    {
        var results = categoryUrl == null
            ? await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("/api/products")
            : await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"/api/products/category/{categoryUrl}"); 
        
        if (results != null)
        {
            Products = results.Data;
        }
        
        ProductsChanged?.Invoke();
    }
    

    public async Task<ServiceResponse<Product>> GetProductById(int productId)
    {
        var results = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"/api/products/{productId}");
        return results;
    }
}