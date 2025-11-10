using Microsoft.EntityFrameworkCore;
using Studio.Core.Entities;
using Studio.Core.Interfaces.Repositories;
using Studio.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class AudioSampleRepository : IAudioSampleRepository
    {
        private readonly AppDbContext _context;

        public AudioSampleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AudioSample>> GetAllAsync()
        {
            return await _context.AudioSamples
                .Include(a => a.Category)
                .ToListAsync();
        }

        public async Task<AudioSample?> GetByIdAsync(int id)
        {
            return await _context.AudioSamples
                .Include(a => a.Category)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAsync(AudioSample sample)
        {
            _context.AudioSamples.Add(sample);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AudioSample sample)
        {
            _context.AudioSamples.Update(sample);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var sample = await _context.AudioSamples.FindAsync(id);
            if (sample != null)
            {
                _context.AudioSamples.Remove(sample);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.AudioSamples.AnyAsync(a => a.Id == id);
        }
    }
}
