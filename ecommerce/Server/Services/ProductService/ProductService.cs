
namespace ecommerce.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    
    public ProductService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<ServiceResponse<List<Product>>> GetAllProductsAsync()
    {
        var response = new ServiceResponse<List<Product>> { Data = await _context.Products.ToListAsync() };
        return response;
    }

    
    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int productId)
    {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == productId);
        
        if (product == null)
        {
            response.Success = false;
            response.Message = "Product not found.";
        }
        else
        {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
    {
        var response = await _context.Products.Where(product => product.Category != null && product.Category.Url == categoryUrl).ToListAsync();
        var data = new ServiceResponse<List<Product>> { Data = response };
        return data;
    }
}