using AutoMapper;
using Diyetiva.WebApi.Context;
using Diyetiva.WebApi.Dtos.MessageDtos;
using Diyetiva.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Diyetiva.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public MessagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDto>>(values));

        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            var value = _mapper.Map<Message>(createMessageDto);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("Mesaj eklendi");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value=_context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDto>(value));

        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value=_context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Mesaj silindi");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok(value);
        }
    }
}
