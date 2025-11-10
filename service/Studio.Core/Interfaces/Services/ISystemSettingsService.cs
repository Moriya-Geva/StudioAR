using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface ISystemSettingService
    {
        Task<IEnumerable<SystemSettingDTO>> GetAllAsync();
        Task<SystemSettingDTO> GetByIdAsync(int id);
        Task<SystemSettingDTO> GetByKeyAsync(string key);
        Task AddAsync(SystemSettingDTO dto);
        Task UpdateAsync(SystemSettingDTO dto);
        Task DeleteAsync(int id);
    }
}
