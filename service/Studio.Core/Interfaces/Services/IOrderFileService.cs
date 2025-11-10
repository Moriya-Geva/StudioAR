using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IOrderFileService
    {
        Task<IEnumerable<OrderFileDTO>> GetAllAsync();
        Task<OrderFileDTO> GetByIdAsync(int id);
        Task<IEnumerable<OrderFileDTO>> GetByOrderIdAsync(int orderId);
        Task AddAsync(OrderFileDTO dto);
        Task UpdateAsync(OrderFileDTO dto);
        Task DeleteAsync(int id);
    }
}
