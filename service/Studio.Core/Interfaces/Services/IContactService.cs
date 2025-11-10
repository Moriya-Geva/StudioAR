using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IContactMessageService
    {
        Task<IEnumerable<ContactMessageDTO>> GetAllAsync();
        Task<ContactMessageDTO> GetByIdAsync(int id);
        Task AddAsync(ContactMessageDTO contactMessageDTO);
        Task UpdateAsync(ContactMessageDTO contactMessageDTO);
        Task DeleteAsync(int id);
    }
}
