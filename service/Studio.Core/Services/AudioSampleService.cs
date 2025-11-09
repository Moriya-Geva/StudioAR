using AutoMapper;
using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces.Repositories;
using Studio.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class AudioSampleService : IAudioSampleService
    {
        private readonly IAudioSampleRepository _repository;
        private readonly IMapper _mapper;

        public AudioSampleService(IAudioSampleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AudioSampleDTO>> GetAllAsync()
        {
            var samples = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<AudioSampleDTO>>(samples);
        }

        public async Task<AudioSampleDTO?> GetByIdAsync(int id)
        {
            var sample = await _repository.GetByIdAsync(id);
            return _mapper.Map<AudioSampleDTO?>(sample);
        }

        public async Task AddAsync(AudioSampleDTO dto)
        {
            var entity = _mapper.Map<AudioSample>(dto);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(AudioSampleDTO dto)
        {
            var entity = _mapper.Map<AudioSample>(dto);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _repository.ExistsAsync(id);
        }
    }
}
