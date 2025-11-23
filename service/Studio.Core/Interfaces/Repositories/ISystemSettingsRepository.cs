using Studio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface ISystemSettingRepository
    {
        Task<IEnumerable<SystemSetting>> GetAllAsync();
        Task<SystemSetting> GetByIdAsync(int id);
        Task<SystemSetting> GetByKeyAsync(string key);
        Task AddAsync(SystemSetting setting);
        Task UpdateAsync(SystemSetting setting);
        Task DeleteAsync(int id);
    }
}
