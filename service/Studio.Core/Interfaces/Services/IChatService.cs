using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IChatMessageService
    {
        Task<IEnumerable<ChatMessageDTO>> GetAllAsync();
        Task<ChatMessageDTO> GetByIdAsync(int id);
        Task<IEnumerable<ChatMessageDTO>> GetByOrderIdAsync(int orderId);
        Task AddAsync(ChatMessageDTO chatMessageDTO);
        Task UpdateAsync(ChatMessageDTO chatMessageDTO);
        Task DeleteAsync(int id);
    }
}
