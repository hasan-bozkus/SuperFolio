using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperFolio.Api.DAL.ApiContext;
using SuperFolio.Api.DAL.Entity;
using System.Linq;

namespace SuperFolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();

            var values = c.Categories.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound("Kategori bulunamadı.");
            }
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            using var c = new Context();
            c.Categories.Add(category);
            c.SaveChanges();
            return Created("Kategori başarılı bir şekilde eklendi.", category);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound("Kategori bulunamadı.");
            }
            c.Categories.Remove(value);
            c.SaveChanges();
            return Ok("Kategori başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public IActionResult EditCategory(Category category)
        {
            using var c = new Context();
            var value = c.Find<Category>(category.CategoryID);
            if (value == null)
            {
                return NotFound("Kategori bulunamadı.");
            }
            value.CategoryName = category.CategoryName;
            c.Categories.Update(value);
            c.SaveChanges();
            return Ok("Kategori başarılı bir şekilde eklendi.");
        }
    }
}
