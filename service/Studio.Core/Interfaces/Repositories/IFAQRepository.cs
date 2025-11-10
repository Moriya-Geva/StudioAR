using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IFAQRepository
    {
        Task<IEnumerable<FAQ>> GetAllAsync();
        Task<FAQ> GetByIdAsync(int id);
        Task<IEnumerable<FAQ>> GetByCategoryIdAsync(int categoryId);
        Task AddAsync(FAQ faq);
        Task UpdateAsync(FAQ faq);
        Task DeleteAsync(int id);
    }
}
