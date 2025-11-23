using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IOrderStatusHistoryRepository
    {
        Task<IEnumerable<OrderStatusHistory>> GetAllAsync();
        Task<OrderStatusHistory> GetByIdAsync(int id);
        Task<IEnumerable<OrderStatusHistory>> GetByOrderIdAsync(int orderId);
        Task AddAsync(OrderStatusHistory history);
        Task UpdateAsync(OrderStatusHistory history);
        Task DeleteAsync(int id);
    }
}
