using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class ChatMessageRepository : IChatMessageRepository
    {
        private readonly AppDbContext _context;

        public ChatMessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChatMessage>> GetAllAsync()
        {
            return await _context.ChatMessages
                                 .Include(c => c.Order)
                                 .ToListAsync();
        }

        public async Task<ChatMessage> GetByIdAsync(int id)
        {
            return await _context.ChatMessages
                                 .Include(c => c.Order)
                                 .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<ChatMessage>> GetByOrderIdAsync(int orderId)
        {
            return await _context.ChatMessages
                                 .Where(c => c.OrderId == orderId)
                                 .ToListAsync();
        }

        public async Task AddAsync(ChatMessage chatMessage)
        {
            await _context.ChatMessages.AddAsync(chatMessage);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ChatMessage chatMessage)
        {
            _context.ChatMessages.Update(chatMessage);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.ChatMessages.FindAsync(id);
            if (entity != null)
            {
                _context.ChatMessages.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
