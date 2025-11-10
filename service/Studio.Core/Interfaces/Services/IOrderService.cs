using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllAsync();
        Task<OrderDTO> GetByIdAsync(int id);
        Task AddAsync(OrderDTO dto);
        Task UpdateAsync(OrderDTO dto);
        Task DeleteAsync(int id);
    }
}
