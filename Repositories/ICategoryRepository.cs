using VoHongHai.Models;

namespace VoHongHai.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
