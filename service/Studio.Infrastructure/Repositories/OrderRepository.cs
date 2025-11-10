using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders
                                 .Include(o => o.User)
                                 .Include(o => o.Category)
                                 .Include(o => o.SubCategory)
                                 .Include(o => o.OrderFiles)
                                 .Include(o => o.DeliverableFiles)
                                 .Include(o => o.StatusHistory)
                                 .Include(o => o.ChatMessages)
                                 .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _context.Orders
                                 .Include(o => o.User)
                                 .Include(o => o.Category)
                                 .Include(o => o.SubCategory)
                                 .Include(o => o.OrderFiles)
                                 .Include(o => o.DeliverableFiles)
                                 .Include(o => o.StatusHistory)
                                 .Include(o => o.ChatMessages)
                                 .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Orders.FindAsync(id);
            if (entity != null)
            {
                _context.Orders.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
