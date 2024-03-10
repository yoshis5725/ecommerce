
using ecommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Server.Controllers;


[ApiController]
[Route("api/[controller]")]


public class ProductController(DataContext context) : Controller
{
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
    {
        var products = await context.Products.ToListAsync();
        var response = new ServiceResponse<List<Product>> { Data = products };
        return Ok(response);
    }
}