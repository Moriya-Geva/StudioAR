using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IDeliverableFileRepository
    {
        Task<IEnumerable<DeliverableFile>> GetAllAsync();
        Task<DeliverableFile> GetByIdAsync(int id);
        Task<IEnumerable<DeliverableFile>> GetByOrderIdAsync(int orderId);
        Task AddAsync(DeliverableFile deliverableFile);
        Task UpdateAsync(DeliverableFile deliverableFile);
        Task DeleteAsync(int id);
    }
}
