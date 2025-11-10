using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces;
using System.Threading.Tasks;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderStatusHistoryController : ControllerBase
    {
        private readonly IOrderStatusHistoryService _service;

        public OrderStatusHistoryController(IOrderStatusHistoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var histories = await _service.GetAllAsync();
            return Ok(histories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var history = await _service.GetByIdAsync(id);
            if (history == null) return NotFound();
            return Ok(history);
        }

        [HttpGet("order/{orderId}")]
        public async Task<IActionResult> GetByOrderId(int orderId)
        {
            var histories = await _service.GetByOrderIdAsync(orderId);
            return Ok(histories);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderStatusHistoryDTO dto)
        {
            await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, OrderStatusHistoryDTO dto)
        {
            if (id != dto.Id) return BadRequest();
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
