using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Server.Controllers;


[ApiController]
[Route("api/[controller]")]


public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;
    

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    
    
    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetAllCategories()
    {
        var result = await _categoryService.GetAllCategoriesAsync();
        return Ok(result);
    }
}