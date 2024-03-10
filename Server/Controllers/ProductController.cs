
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Server.Controllers;


[ApiController]
[Route("api/[controller]")]


public class ProductController(DataContext context) : Controller
{
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await context.Products.ToListAsync();
        return Ok(products);
    }
}