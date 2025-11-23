using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class DeliverableFileRepository : IDeliverableFileRepository
    {
        private readonly AppDbContext _context;

        public DeliverableFileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DeliverableFile>> GetAllAsync()
        {
            return await _context.DeliverableFiles.Include(d => d.Order).ToListAsync();
        }

        public async Task<DeliverableFile> GetByIdAsync(int id)
        {
            return await _context.DeliverableFiles
                                 .Include(d => d.Order)
                                 .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<DeliverableFile>> GetByOrderIdAsync(int orderId)
        {
            return await _context.DeliverableFiles
                                 .Where(d => d.OrderId == orderId)
                                 .Include(d => d.Order)
                                 .ToListAsync();
        }

        public async Task AddAsync(DeliverableFile deliverableFile)
        {
            await _context.DeliverableFiles.AddAsync(deliverableFile);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DeliverableFile deliverableFile)
        {
            _context.DeliverableFiles.Update(deliverableFile);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.DeliverableFiles.FindAsync(id);
            if (entity != null)
            {
                _context.DeliverableFiles.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
