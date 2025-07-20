using Diyetiva.WebApi.Context;
using Diyetiva.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighlightsController : ControllerBase
    {
        private readonly ApiContext _context;

        public HighlightsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult HighlightList()
        {
            var values=_context.Highlights.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateHighlight(Highlight highlight)
        {
            _context.Highlights.Add(highlight);
            _context.SaveChanges();
            return Ok("Öne çıkan başarılı şekilde eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteHighlight(int id)
        {
           var value= _context.Highlights.Find(id);
            _context.Highlights.Remove(value);
            _context.SaveChanges();
            return Ok("Öne çıkan silindi.");
        }
        [HttpGet("GetHighlight")]
        public IActionResult GetHighlight(int id)
        {
           return Ok(_context.Highlights.Find(id));
           
           }
        [HttpPut]
        public IActionResult UpdateHighlight(Highlight highlight)
        {
            _context.Highlights.Update(highlight);
            _context.SaveChanges();
            return Ok("Öne çıkan güncellendi");
        }
    }
}
