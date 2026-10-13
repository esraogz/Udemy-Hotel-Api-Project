using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController(IRoomService _roomService) : ControllerBase
    {

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _roomService.TInsert(Room);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var Room = _roomService.TGetById(id);
            _roomService.TDelete(Room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }
    }
}
