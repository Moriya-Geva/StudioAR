using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface ISubCategoryRepository
    {
        Task<IEnumerable<SubCategory>> GetAllAsync();
        Task<SubCategory> GetByIdAsync(int id);
        Task<IEnumerable<SubCategory>> GetByCategoryIdAsync(int categoryId);
        Task AddAsync(SubCategory subCategory);
        Task UpdateAsync(SubCategory subCategory);
        Task DeleteAsync(int id);
    }
}
