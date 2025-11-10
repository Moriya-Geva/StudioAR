using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class SystemSettingRepository : ISystemSettingRepository
    {
        private readonly AppDbContext _context;

        public SystemSettingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SystemSetting>> GetAllAsync()
        {
            return await _context.SystemSettings.ToListAsync();
        }

        public async Task<SystemSetting> GetByIdAsync(int id)
        {
            return await _context.SystemSettings.FindAsync(id);
        }

        public async Task<SystemSetting> GetByKeyAsync(string key)
        {
            return await _context.SystemSettings.FirstOrDefaultAsync(s => s.Key == key);
        }

        public async Task AddAsync(SystemSetting setting)
        {
            await _context.SystemSettings.AddAsync(setting);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SystemSetting setting)
        {
            _context.SystemSettings.Update(setting);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.SystemSettings.FindAsync(id);
            if (entity != null)
            {
                _context.SystemSettings.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
