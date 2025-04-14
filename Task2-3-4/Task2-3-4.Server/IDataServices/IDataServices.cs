using _14_4_24.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace _14_4_24.Server.Services
{
    public interface IDataServices
    {
        public List<Category> getAllCategory();

        public Category getCategoryById(int id);

        public bool deleteCategory(int id);
    }
}
