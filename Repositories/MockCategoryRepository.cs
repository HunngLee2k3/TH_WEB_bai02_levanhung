using Microsoft.AspNetCore.Mvc;
using VoHongHai.Models;

namespace VoHongHai.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
{
            new Category { Id = 1, Name = "Ga ran" },
            new Category { Id = 2, Name = "Khoai tay chien" },
// Thêm các category khác
};
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
