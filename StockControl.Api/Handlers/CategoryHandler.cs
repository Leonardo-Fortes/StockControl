using Microsoft.EntityFrameworkCore;
using StockControl.Api.Data;
using StockControl.Core.Handlers;
using StockControl.Core.Models;
using StockControl.Core.Requests.Categories;
using StockControl.Core.Responses;

namespace StockControl.Api.Handlers
{
    public class CategoryHandler(AppDBContext context) : ICategoryHandler
    {
        public async Task<Response<Category?>> CreateAsync(CreateCategoryRequest request)
        {
            try
            {
                var categories = new Category()
                {
                    Title = request.Title,
                    Description = request.Description,
                    UserId = request.UserId
                };
                await context.AddAsync(categories);
                await context.SaveChangesAsync();

                return new Response<Category?>(categories, 200, "Categoria criada com exito");
            }

            catch
            {
                return new Response<Category?>(null, 500, "Falha ao criar categoria");
            }
            
        }

        public async Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request)
        {
            try 
            {
                var categories = await context.Categories.FirstOrDefaultAsync(x => x.Id == request.Id && x.UserId == request.UserId);
                if(categories is null)
                    return new Response<Category?>(null, 500, "Categoria não encontrada");

                context.Categories.Remove(categories);
                await context.SaveChangesAsync();
                return new Response<Category?>(categories, 200, "Categoria deletada com exito");
            }
            catch 
            { 
                return new Response<Category?>(null, 500, "Falha ao deletar Categoria"); 
            }
        }

        public async Task<List<PagedResponse<Category>?>> GetAllAsync(GetAllCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
