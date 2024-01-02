using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Server.Controllers;


[ApiController]
[Route("api/[controller]")]


public class ProductsController : Controller
{
    private readonly IProductService _productService;


    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }


    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetAllProducts()
    {
        var result = await _productService.GetAllProductsAsync();
        return Ok(result);
    }
    
    
    [HttpGet("{productId:int}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int productId)
    {
        var result = await _productService.GetProductByIdAsync(productId);
        return Ok(result);
    }
    
    
    [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
    {
        var result = await _productService.GetProductsByCategoryAsync(categoryUrl);
        return Ok(result);
    }
}