using Studio.Core.Entities;
using Studio.Core.Interfaces;
using Studio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly AppDbContext _context;

        public SubCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubCategory>> GetAllAsync()
        {
            return await _context.SubCategories
                                 .Include(sc => sc.Category)
                                 .Include(sc => sc.AudioSamples)
                                 .ToListAsync();
        }

        public async Task<SubCategory> GetByIdAsync(int id)
        {
            return await _context.SubCategories
                                 .Include(sc => sc.Category)
                                 .Include(sc => sc.AudioSamples)
                                 .FirstOrDefaultAsync(sc => sc.Id == id);
        }

        public async Task<IEnumerable<SubCategory>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.SubCategories
                                 .Where(sc => sc.CategoryId == categoryId)
                                 .Include(sc => sc.Category)
                                 .Include(sc => sc.AudioSamples)
                                 .ToListAsync();
        }

        public async Task AddAsync(SubCategory subCategory)
        {
            await _context.SubCategories.AddAsync(subCategory);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.SubCategories.FindAsync(id);
            if (entity != null)
            {
                _context.SubCategories.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
