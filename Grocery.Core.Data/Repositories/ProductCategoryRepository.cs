using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategories;

        public ProductCategoryRepository()
        {
            productCategories = new List<ProductCategory>
            {
                new ProductCategory(1, 1), // Melk → Zuivel
                new ProductCategory(2, 1), // Kaas → Zuivel
                new ProductCategory(3, 2), // Brood → Brood & Bakkerij
                new ProductCategory(4, 3)  // Cornflakes → Ontbijtgranen
            };
        }

        public List<ProductCategory> GetAll() => productCategories;

        public List<ProductCategory> GetByCategory(int categoryId) =>
            productCategories.Where(pc => pc.CategoryId == categoryId).ToList();

        public List<ProductCategory> GetByProduct(int productId) =>
            productCategories.Where(pc => pc.ProductId == productId).ToList();
    }
}
