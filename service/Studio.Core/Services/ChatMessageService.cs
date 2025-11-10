using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class ChatMessageService : IChatMessageService
    {
        private readonly IChatMessageRepository _repository;
        private readonly IMapper _mapper;

        public ChatMessageService(IChatMessageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChatMessageDTO>> GetAllAsync()
        {
            var messages = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ChatMessageDTO>>(messages);
        }

        public async Task<ChatMessageDTO> GetByIdAsync(int id)
        {
            var message = await _repository.GetByIdAsync(id);
            return _mapper.Map<ChatMessageDTO>(message);
        }

        public async Task<IEnumerable<ChatMessageDTO>> GetByOrderIdAsync(int orderId)
        {
            var messages = await _repository.GetByOrderIdAsync(orderId);
            return _mapper.Map<IEnumerable<ChatMessageDTO>>(messages);
        }

        public async Task AddAsync(ChatMessageDTO chatMessageDTO)
        {
            var message = _mapper.Map<ChatMessage>(chatMessageDTO);
            await _repository.AddAsync(message);
        }

        public async Task UpdateAsync(ChatMessageDTO chatMessageDTO)
        {
            var message = _mapper.Map<ChatMessage>(chatMessageDTO);
            await _repository.UpdateAsync(message);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
