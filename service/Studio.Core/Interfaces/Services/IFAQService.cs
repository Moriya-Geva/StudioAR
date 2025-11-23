using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IFAQService
    {
        Task<IEnumerable<FAQDTO>> GetAllAsync();
        Task<FAQDTO> GetByIdAsync(int id);
        Task<IEnumerable<FAQDTO>> GetByCategoryIdAsync(int categoryId);
        Task AddAsync(FAQDTO dto);
        Task UpdateAsync(FAQDTO dto);
        Task DeleteAsync(int id);
    }
}
