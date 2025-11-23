using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class ContactMessageRepository : IContactMessageRepository
    {
        private readonly AppDbContext _context;

        public ContactMessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContactMessage>> GetAllAsync()
        {
            return await _context.ContactMessages.ToListAsync();
        }

        public async Task<ContactMessage> GetByIdAsync(int id)
        {
            return await _context.ContactMessages.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(ContactMessage contactMessage)
        {
            await _context.ContactMessages.AddAsync(contactMessage);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ContactMessage contactMessage)
        {
            _context.ContactMessages.Update(contactMessage);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.ContactMessages.FindAsync(id);
            if (entity != null)
            {
                _context.ContactMessages.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
