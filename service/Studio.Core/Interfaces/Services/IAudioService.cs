using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.DTOs;

namespace Studio.Core.Interfaces.Services
{
        public interface IAudioSampleService
        {
            Task<IEnumerable<AudioSampleDTO>> GetAllAsync();
            Task<AudioSampleDTO?> GetByIdAsync(int id);
            Task AddAsync(AudioSampleDTO audioSampleDto);
            Task UpdateAsync(AudioSampleDTO audioSampleDto);
            Task DeleteAsync(int id);
        }
    
}
