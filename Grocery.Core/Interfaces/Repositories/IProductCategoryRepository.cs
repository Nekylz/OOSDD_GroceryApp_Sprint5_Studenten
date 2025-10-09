using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAll();
        List<ProductCategory> GetByCategory(int categoryId);
        List<ProductCategory> GetByProduct(int productId);
    }
}
