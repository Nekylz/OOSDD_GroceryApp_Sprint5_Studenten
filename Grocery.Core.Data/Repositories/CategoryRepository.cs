using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;
        public CategoryRepository()
        {
            categories = new List<Category>
            {
                new Category(1, "Zuivel"),
                new Category(2, "Brood"),
                new Category(3, "Ontbijtgranen")
            };
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        public Category? Get(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }
    }
}