using _14_4_24.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _14_4_24.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IDataServices _data;
        public CategoryController(IDataServices data) {
            _data = data;
        }

        [HttpGet("AllCategory")]
        public IActionResult getAllCategories()
        {
            var Categories = _data.getAllCategory();
            return Ok(Categories);
        }

        [HttpGet("getCategoryById/{id}")]
        public IActionResult getCategoryById(int id)
        {
            var Category = _data.getCategoryById(id);
            if (Category != null)
            {
                return Ok(Category); //200
            }
            else
            {
                return NotFound();//404
            }
        }

        [HttpDelete("deleteCategory/{id}")]
        public IActionResult deleteCategory(int id)
        {
            var Category = _data.deleteCategory(id);
            if (Category != false)
            {
                return Ok();
            }
            return NotFound();
        }

        //[HttpGet("getStudentByName/{name}")]
        //public IActionResult getStudentByName(string name)
        //{
        //    var students = _data.getStudentByName(name);
        //    if (students != null)
        //    {
        //        return Ok(students);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet("firstStudent")]
        //public IActionResult getFirstStudent()
        //{
        //    var student = _data.getFirstStudent();
        //    return Ok(student);
        //}

        //[HttpDelete("delete student")]
        //public IActionResult deleteStudent(int id)
        //{
        //    var student = _data.deleteStudent(id);
        //    if (student != false)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

    }
}
