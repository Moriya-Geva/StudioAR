using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces;
using System.Threading.Tasks;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatMessageController : ControllerBase
    {
        private readonly IChatMessageService _service;

        public ChatMessageController(IChatMessageService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var messages = await _service.GetAllAsync();
            return Ok(messages);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var message = await _service.GetByIdAsync(id);
            if (message == null)
                return NotFound();
            return Ok(message);
        }

        [HttpGet("order/{orderId}")]
        public async Task<IActionResult> GetByOrderId(int orderId)
        {
            var messages = await _service.GetByOrderIdAsync(orderId);
            return Ok(messages);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChatMessageDTO dto)
        {
            await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ChatMessageDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            await _service.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
