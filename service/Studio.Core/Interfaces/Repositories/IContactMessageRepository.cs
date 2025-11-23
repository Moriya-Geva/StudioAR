using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IContactMessageRepository
    {
        Task<IEnumerable<ContactMessage>> GetAllAsync();
        Task<ContactMessage> GetByIdAsync(int id);
        Task AddAsync(ContactMessage contactMessage);
        Task UpdateAsync(ContactMessage contactMessage);
        Task DeleteAsync(int id);
    }
}
