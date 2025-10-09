using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IProductCategoryService
    {
        List<ProductCategory> GetByCategory(int categoryId);
        List<ProductCategory> GetByProduct(int productId);
    }
}
