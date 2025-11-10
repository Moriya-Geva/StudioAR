using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IDeliverableFileService
    {
        Task<IEnumerable<DeliverableFileDTO>> GetAllAsync();
        Task<DeliverableFileDTO> GetByIdAsync(int id);
        Task<IEnumerable<DeliverableFileDTO>> GetByOrderIdAsync(int orderId);
        Task AddAsync(DeliverableFileDTO dto);
        Task UpdateAsync(DeliverableFileDTO dto);
        Task DeleteAsync(int id);
    }
}
