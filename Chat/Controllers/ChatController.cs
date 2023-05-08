using Chat.Database;
using Chat.Models;
using Chat.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ChatContext _context;

        public ChatController(ChatContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return (IActionResult)_context.Chatroom.Include(Chat => Chat).Where(Chat => Chat.Id == id && !Chat.IsDeleted);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateChatroom request)
        {
/*
    TODO ƒобавить конструктор дл€ создани€ Chatroom по данным из RequestBody
 */
            _context.Chatroom.Add(new Models.Chatroom());
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public IActionResult Update([FromBody] CreateChatroom request, [FromRoute] int id, Chatroom chatroom)
        {
            Chatroom chat = (Chatroom)_context.Chatroom.Include(Chat => Chat).Where(Chat => Chat.Id == id && !Chat.IsDeleted);
            chat = chatroom;
            _context.Chatroom.Update(chat);
            return Ok();
        }
    }
}