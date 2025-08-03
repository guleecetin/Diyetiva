using Diyetiva.WebApi.Context;
using Diyetiva.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {

        private readonly ApiContext _context;

        public ServicesController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateServices(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return Ok("Yeni Hizmet Eklendi.");

        }
        [HttpGet]
        public IActionResult ServicesList()
        {
            var values = _context.Services.ToList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteServices(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return Ok("Hizmet silindi.");

        }
        [HttpGet("GetService")]
        public IActionResult GetServices(int id)
        {
            var value = _context.Services.Find(id);
            return Ok(value);

        }
        [HttpPut]
        public IActionResult UpdateServices(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return Ok("Hizmet Güncellendi");

        }

    }
}