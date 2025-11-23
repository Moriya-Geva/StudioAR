using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces;
using System.Threading.Tasks;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemSettingController : ControllerBase
    {
        private readonly ISystemSettingService _service;

        public SystemSettingController(ISystemSettingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var settings = await _service.GetAllAsync();
            return Ok(settings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var setting = await _service.GetByIdAsync(id);
            if (setting == null) return NotFound();
            return Ok(setting);
        }

        [HttpGet("key/{key}")]
        public async Task<IActionResult> GetByKey(string key)
        {
            var setting = await _service.GetByKeyAsync(key);
            if (setting == null) return NotFound();
            return Ok(setting);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SystemSettingDTO dto)
        {
            await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetByKey), new { key = dto.Key }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, SystemSettingDTO dto)
        {
            // אין ב־DTO Id, אפשר להשוות לפי Key או להוסיף Id ב־DTO
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
