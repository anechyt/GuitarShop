using GuitarShop.Backend.Application.Common.Facade;
using GuitarShop.Backend.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Facade _facade;
        public CategoryController(Facade facade)
        {
            _facade = facade;
        }
        [HttpGet("getallcategory")]
        public IActionResult GetAllCategory()
        {
            var result = _facade.GetAllCategory();
            return Ok(result);
        }
        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            _facade.AddCategory(category);
            return Ok(category.Id);
        }
    }
}
