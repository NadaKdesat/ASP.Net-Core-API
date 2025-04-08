using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task1.Server.Models;

namespace Task1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("id/{id}")]
        public ActionResult GetProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpGet("name/{name}")]
        public ActionResult GetProductByName(string name)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductName == name);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpGet("first")]
        public ActionResult GetFirstProduct()
        {
            var firstProduct = _context.Products.FirstOrDefault();
            if (firstProduct == null)
                return NotFound();
            return Ok(firstProduct);
        }
    }
}
