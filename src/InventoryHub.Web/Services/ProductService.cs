using System.Net.Http.Json;
using InventoryHub.Shared.Models;

public class ProductService
{
    private readonly HttpClient _httpClient;
    private Product[]? _cachedProducts;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Product[]?> GetProductsAsync()
    {
        if (_cachedProducts != null)
        {
            return _cachedProducts;
        }
        _cachedProducts = await _httpClient.GetFromJsonAsync<Product[]>("http://localhost:5078/api/productlist");
        return _cachedProducts;
    }

    public void ClearCache()
    {
        _cachedProducts = null;
    }
}