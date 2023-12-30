using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Server.Controllers;


[ApiController]
[Route("api/[controller]")]


public class ProductsController : Controller
{
    private readonly DataContext _context;

    
    public ProductsController(DataContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }
}