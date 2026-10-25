using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController(ISendMessageService _sendMessageService) : ControllerBase
    {
        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var sendMessage = _sendMessageService.TGetById(id);
            _sendMessageService.TDelete(sendMessage);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var value = _sendMessageService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("GetInbox")]
        public IActionResult GetInbox()
        {
            var values = _sendMessageService.TGetInbox();
            return Ok(values);
        }

        [HttpGet("GetSendbox")]
        public IActionResult GetSendBox()
        {
            var values = _sendMessageService.TGetSendbox();
            return Ok(values);
        }
    }
}
