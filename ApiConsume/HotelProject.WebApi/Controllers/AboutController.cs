using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController(IAboutService _aboutService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutService.TGetList();
            return Ok(values);  
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var about = _aboutService.TGetById(id);
            _aboutService.TDelete(about);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var about = _aboutService.TGetById(id);
            return Ok(about);
        }
    }
}
