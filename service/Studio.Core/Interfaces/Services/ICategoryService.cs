using System.Collections.Generic;
using System.Threading.Tasks;
using Studio.Core.DTOs;

namespace Studio.Core.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO?> GetByIdAsync(int id);
        Task AddAsync(CategoryDTO categoryDto);
        Task UpdateAsync(CategoryDTO categoryDto);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
