
using StockControl.Core.Models;
using StockControl.Core.Requests.Categories;
using StockControl.Core.Responses;

namespace StockControl.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>>CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<List<PagedResponse<Category>?>> GetAllAsync(GetAllCategoryRequest request);
    }
}
