using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AudioSampleController : ControllerBase
    {
        private readonly IAudioSampleService _service;

        public AudioSampleController(IAudioSampleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioSampleDTO>>> GetAll()
        {
            var samples = await _service.GetAllAsync();
            return Ok(samples);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AudioSampleDTO>> GetById(int id)
        {
            var sample = await _service.GetByIdAsync(id);
            if (sample == null) return NotFound();
            return Ok(sample);
        }

        [HttpPost]
        public async Task<ActionResult> Create(AudioSampleDTO dto)
        {
            await _service.AddAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, AudioSampleDTO dto)
        {
            dto.Id = id;
            await _service.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
