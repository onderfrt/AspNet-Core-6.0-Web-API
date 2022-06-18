using NLayer.Core.Dtos;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryWithProductsAsync(int categoryId);
    }
}
