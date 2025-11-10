using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class OrderStatusHistoryRepository : IOrderStatusHistoryRepository
    {
        private readonly AppDbContext _context;

        public OrderStatusHistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderStatusHistory>> GetAllAsync()
        {
            return await _context.OrderStatusHistories
                                 .Include(h => h.Order)
                                 .Include(h => h.ChangedBy)
                                 .ToListAsync();
        }

        public async Task<OrderStatusHistory> GetByIdAsync(int id)
        {
            return await _context.OrderStatusHistories
                                 .Include(h => h.Order)
                                 .Include(h => h.ChangedBy)
                                 .FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<IEnumerable<OrderStatusHistory>> GetByOrderIdAsync(int orderId)
        {
            return await _context.OrderStatusHistories
                                 .Where(h => h.OrderId == orderId)
                                 .Include(h => h.Order)
                                 .Include(h => h.ChangedBy)
                                 .ToListAsync();
        }

        public async Task AddAsync(OrderStatusHistory history)
        {
            await _context.OrderStatusHistories.AddAsync(history);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(OrderStatusHistory history)
        {
            _context.OrderStatusHistories.Update(history);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.OrderStatusHistories.FindAsync(id);
            if (entity != null)
            {
                _context.OrderStatusHistories.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
