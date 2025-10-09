using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _repo;

        public ProductCategoryService(IProductCategoryRepository repo)
        {
            _repo = repo;
        }

        public List<ProductCategory> GetByCategory(int categoryId) => _repo.GetByCategory(categoryId);

        public List<ProductCategory> GetByProduct(int productId) => _repo.GetByProduct(productId);
    }
}
