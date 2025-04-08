using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task1.Server.Models;

namespace Task1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateroryController : ControllerBase
    {
        private readonly MyDbContext _context;
        public CateroryController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAllCategory() { 
            var categories=_context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("id/{id}")]
        public ActionResult GetCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpGet("name/{name}")]
        public ActionResult GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpGet("first")]
        public ActionResult GetFirstCategory()
        {
            var firstCategory = _context.Categories.FirstOrDefault();
            if (firstCategory == null)
                return NotFound();
            return Ok(firstCategory);
        }
    }
}
