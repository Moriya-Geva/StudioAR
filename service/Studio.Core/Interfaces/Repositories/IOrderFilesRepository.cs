using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IOrderFileRepository
    {
        Task<IEnumerable<OrderFile>> GetAllAsync();
        Task<OrderFile> GetByIdAsync(int id);
        Task<IEnumerable<OrderFile>> GetByOrderIdAsync(int orderId);
        Task AddAsync(OrderFile file);
        Task UpdateAsync(OrderFile file);
        Task DeleteAsync(int id);
    }
}
