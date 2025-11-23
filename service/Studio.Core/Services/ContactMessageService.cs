using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class ContactMessageService : IContactMessageService
    {
        private readonly IContactMessageRepository _repository;
        private readonly IMapper _mapper;

        public ContactMessageService(IContactMessageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContactMessageDTO>> GetAllAsync()
        {
            var messages = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ContactMessageDTO>>(messages);
        }

        public async Task<ContactMessageDTO> GetByIdAsync(int id)
        {
            var message = await _repository.GetByIdAsync(id);
            return _mapper.Map<ContactMessageDTO>(message);
        }

        public async Task AddAsync(ContactMessageDTO contactMessageDTO)
        {
            var message = _mapper.Map<ContactMessage>(contactMessageDTO);
            await _repository.AddAsync(message);
        }

        public async Task UpdateAsync(ContactMessageDTO contactMessageDTO)
        {
            var message = _mapper.Map<ContactMessage>(contactMessageDTO);
            await _repository.UpdateAsync(message);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
