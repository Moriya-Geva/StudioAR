using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class SystemSettingService : ISystemSettingService
    {
        private readonly ISystemSettingRepository _repository;
        private readonly IMapper _mapper;

        public SystemSettingService(ISystemSettingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SystemSettingDTO>> GetAllAsync()
        {
            var settings = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<SystemSettingDTO>>(settings);
        }

        public async Task<SystemSettingDTO> GetByIdAsync(int id)
        {
            var setting = await _repository.GetByIdAsync(id);
            return _mapper.Map<SystemSettingDTO>(setting);
        }

        public async Task<SystemSettingDTO> GetByKeyAsync(string key)
        {
            var setting = await _repository.GetByKeyAsync(key);
            return _mapper.Map<SystemSettingDTO>(setting);
        }

        public async Task AddAsync(SystemSettingDTO dto)
        {
            var setting = _mapper.Map<SystemSetting>(dto);
            await _repository.AddAsync(setting);
        }

        public async Task UpdateAsync(SystemSettingDTO dto)
        {
            var setting = _mapper.Map<SystemSetting>(dto);
            await _repository.UpdateAsync(setting);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
