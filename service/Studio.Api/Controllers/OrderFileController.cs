using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces;
using System.Threading.Tasks;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderFileController : ControllerBase
    {
        private readonly IOrderFileService _service;

        public OrderFileController(IOrderFileService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var files = await _service.GetAllAsync();
            return Ok(files);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var file = await _service.GetByIdAsync(id);
            if (file == null) return NotFound();
            return Ok(file);
        }

        [HttpGet("order/{orderId}")]
        public async Task<IActionResult> GetByOrderId(int orderId)
        {
            var files = await _service.GetByOrderIdAsync(orderId);
            return Ok(files);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderFileDTO dto)
        {
            await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, OrderFileDTO dto)
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
