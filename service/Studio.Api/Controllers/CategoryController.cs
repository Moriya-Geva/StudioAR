using Microsoft.AspNetCore.Mvc;
using Studio.Core.DTOs;
using Studio.Core.Interfaces.Services;

namespace Studio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/category
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        // GET: api/category/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
                return NotFound(new { Message = $"Category with ID {id} not found." });

            return Ok(category);
        }

        // POST: api/category
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO categoryDto)
        {
            if (categoryDto == null)
                return BadRequest(new { Message = "Category data is required." });

            await _categoryService.AddAsync(categoryDto);
            return CreatedAtAction(nameof(GetById), new { id = categoryDto.Id }, categoryDto);
        }

        // PUT: api/category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return BadRequest(new { Message = "ID mismatch." });

            var exists = await _categoryService.ExistsAsync(id);
            if (!exists)
                return NotFound(new { Message = $"Category with ID {id} not found." });

            await _categoryService.UpdateAsync(categoryDto);
            return NoContent();
        }

        // DELETE: api/category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = await _categoryService.ExistsAsync(id);
            if (!exists)
                return NotFound(new { Message = $"Category with ID {id} not found." });

            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}
