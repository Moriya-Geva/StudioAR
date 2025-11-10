using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IChatMessageRepository
    {
        Task<IEnumerable<ChatMessage>> GetAllAsync();
        Task<ChatMessage> GetByIdAsync(int id);
        Task<IEnumerable<ChatMessage>> GetByOrderIdAsync(int orderId);
        Task AddAsync(ChatMessage chatMessage);
        Task UpdateAsync(ChatMessage chatMessage);
        Task DeleteAsync(int id);
    }
}
