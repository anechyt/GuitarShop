using GuitarShop.Backend.Application.Common.Facade;
using GuitarShop.Backend.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitarController : ControllerBase
    {
        private readonly Facade _facade;
        public GuitarController(Facade facade)
        {
            _facade = facade;
        }
        [HttpGet("getallguitars")]
        public IActionResult GetAllGuitars()
        {
            var result = _facade.GetAllGuitars();
            return Ok(result);
        }

        [HttpPost("AddGuitar")]
        public IActionResult AddGuitar(Guitar guitar)
        {
            _facade.AddGuitar(guitar);
            return Ok(guitar.Id);
        }

        [HttpGet("getclassicguitars")]
        public IActionResult GetClassicGuitar()
        {
            var result = _facade.GetClassicGuitar();
            return Ok(result);
        }

    }
}
