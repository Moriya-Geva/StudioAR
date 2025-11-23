using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class OrderStatusHistoryService : IOrderStatusHistoryService
    {
        private readonly IOrderStatusHistoryRepository _repository;
        private readonly IMapper _mapper;

        public OrderStatusHistoryService(IOrderStatusHistoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderStatusHistoryDTO>> GetAllAsync()
        {
            var histories = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderStatusHistoryDTO>>(histories);
        }

        public async Task<OrderStatusHistoryDTO> GetByIdAsync(int id)
        {
            var history = await _repository.GetByIdAsync(id);
            return _mapper.Map<OrderStatusHistoryDTO>(history);
        }

        public async Task<IEnumerable<OrderStatusHistoryDTO>> GetByOrderIdAsync(int orderId)
        {
            var histories = await _repository.GetByOrderIdAsync(orderId);
            return _mapper.Map<IEnumerable<OrderStatusHistoryDTO>>(histories);
        }

        public async Task AddAsync(OrderStatusHistoryDTO dto)
        {
            var history = _mapper.Map<OrderStatusHistory>(dto);
            await _repository.AddAsync(history);
        }

        public async Task UpdateAsync(OrderStatusHistoryDTO dto)
        {
            var history = _mapper.Map<OrderStatusHistory>(dto);
            await _repository.UpdateAsync(history);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
