using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class OrderFileRepository : IOrderFileRepository
    {
        private readonly AppDbContext _context;

        public OrderFileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderFile>> GetAllAsync()
        {
            return await _context.OrderFiles
                                 .Include(f => f.Order)
                                 .ToListAsync();
        }

        public async Task<OrderFile> GetByIdAsync(int id)
        {
            return await _context.OrderFiles
                                 .Include(f => f.Order)
                                 .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<OrderFile>> GetByOrderIdAsync(int orderId)
        {
            return await _context.OrderFiles
                                 .Where(f => f.OrderId == orderId)
                                 .Include(f => f.Order)
                                 .ToListAsync();
        }

        public async Task AddAsync(OrderFile file)
        {
            await _context.OrderFiles.AddAsync(file);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(OrderFile file)
        {
            _context.OrderFiles.Update(file);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.OrderFiles.FindAsync(id);
            if (entity != null)
            {
                _context.OrderFiles.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
