using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.Entities;

namespace Studio.Core.Interfaces.Repositories
{
        public interface IAudioSampleRepository
        {
            Task<IEnumerable<AudioSample>> GetAllAsync();
            Task<AudioSample?> GetByIdAsync(int id);
            Task AddAsync(AudioSample audioSample);
            Task UpdateAsync(AudioSample audioSample);
            Task DeleteAsync(int id);
            Task<bool> ExistsAsync(int id);
        }
    }