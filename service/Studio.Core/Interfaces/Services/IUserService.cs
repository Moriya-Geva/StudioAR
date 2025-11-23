using Studio.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task<UserDTO> GetByIdAsync(int id);
        Task<UserDTO> GetByEmailAsync(string email);
        Task AddAsync(UserDTO dto, string password);
        Task UpdateAsync(UserDTO dto);
        Task DeleteAsync(int id);
    }
}
