using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface ISubCategoryService
    {
        Task<IEnumerable<SubCategoryDTO>> GetAllAsync();
        Task<SubCategoryDTO> GetByIdAsync(int id);
        Task<IEnumerable<SubCategoryDTO>> GetByCategoryIdAsync(int categoryId);
        Task AddAsync(SubCategoryDTO dto);
        Task UpdateAsync(SubCategoryDTO dto);
        Task DeleteAsync(int id);
    }
}
