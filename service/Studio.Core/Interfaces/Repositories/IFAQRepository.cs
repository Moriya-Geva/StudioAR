using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.Entities;

namespace Studio.Core.Interfaces.Repositories
{
    public interface IFAQRepository
    {
        Task<IEnumerable<FAQ>> GetAllAsync();
        Task<FAQ> GetByIdAsync(int id);
        Task AddAsync(FAQ faq);
        Task UpdateAsync(FAQ faq);
        Task DeleteAsync(int id);
    }
}
