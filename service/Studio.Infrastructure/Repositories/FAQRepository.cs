using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class FAQRepository : IFAQRepository
    {
        private readonly AppDbContext _context;

        public FAQRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FAQ>> GetAllAsync()
        {
            return await _context.FAQs
                                 .Include(f => f.Category)
                                 .ToListAsync();
        }

        public async Task<FAQ> GetByIdAsync(int id)
        {
            return await _context.FAQs
                                 .Include(f => f.Category)
                                 .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<FAQ>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.FAQs
                                 .Where(f => f.CategoryId == categoryId)
                                 .Include(f => f.Category)
                                 .ToListAsync();
        }

        public async Task AddAsync(FAQ faq)
        {
            await _context.FAQs.AddAsync(faq);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(FAQ faq)
        {
            _context.FAQs.Update(faq);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.FAQs.FindAsync(id);
            if (entity != null)
            {
                _context.FAQs.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
