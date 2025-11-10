using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IOrderStatusHistoryService
    {
        Task<IEnumerable<OrderStatusHistoryDTO>> GetAllAsync();
        Task<OrderStatusHistoryDTO> GetByIdAsync(int id);
        Task<IEnumerable<OrderStatusHistoryDTO>> GetByOrderIdAsync(int orderId);
        Task AddAsync(OrderStatusHistoryDTO dto);
        Task UpdateAsync(OrderStatusHistoryDTO dto);
        Task DeleteAsync(int id);
    }
}
