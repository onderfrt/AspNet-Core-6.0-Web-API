using NLayer.Core.Dtos;

namespace NLayer.WEB.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<List<ProductWithCategoryDto>> GetProductsWithCategories()
        //{
        //    var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/GetProductsWithCategory");

        //    return response.Data;
        //}
        //public async Task<ProductDto> Save(ProductDto newProduct)
        //{
        //    var response = await _httpClient.PostAsJsonAsync("products", newProduct);
        //    var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
        //    return responseBody.Data;
        //}

        //public async Task<List<CategoryDto>> GetAllAsync()
        //{
        //    var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("categories");
        //    return response.Data;
        //}

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("categories");
            return response.Data;
        }
    }
}
