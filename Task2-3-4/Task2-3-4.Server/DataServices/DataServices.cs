using _14_4_24.Server.Models;
using _14_4_24.Server.Services;

namespace _14_4_24.Server.DataServices
{
    public class DataServices : IDataServices
    {
        private readonly MyDbContext _context;
        public DataServices(MyDbContext context)
        {
            _context = context;
        }
        public List<Category> getAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category getCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public bool deleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
