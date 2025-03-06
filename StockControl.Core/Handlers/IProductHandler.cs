using StockControl.Core.Models;
using StockControl.Core.Requests.Products;
using StockControl.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Core.Handlers
{
    public interface IProductHandler
    {
        Task<Response<Product>?>CreateAsync(CreateProductRequest request);
        Task<Response<Product>?> UpdateAsync(UpdateProductRequest request);
        Task<Response<Product>?> DeleteAsync(DeleteProductRequest request);
        Task<Response<Product>?> GetByIdAsync(GetProductByIdRequest request);
        Task<List<PagedResponse<Product>?>> GetAllAsync(GetAllProductRequest request);
    }
}
