using System.Net.Http.Json;

namespace ecommerce.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;
    public List<Category>? Categories { get; set; }


    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    
    public async Task GetAllCategories()
    {
        var results = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
        
        if (results != null)
        {
            Categories = results.Data;
        }
    }
}