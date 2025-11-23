using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class OrderFileService : IOrderFileService
    {
        private readonly IOrderFileRepository _repository;
        private readonly IMapper _mapper;

        public OrderFileService(IOrderFileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderFileDTO>> GetAllAsync()
        {
            var files = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<OrderFileDTO>>(files);
        }

        public async Task<OrderFileDTO> GetByIdAsync(int id)
        {
            var file = await _repository.GetByIdAsync(id);
            return _mapper.Map<OrderFileDTO>(file);
        }

        public async Task<IEnumerable<OrderFileDTO>> GetByOrderIdAsync(int orderId)
        {
            var files = await _repository.GetByOrderIdAsync(orderId);
            return _mapper.Map<IEnumerable<OrderFileDTO>>(files);
        }

        public async Task AddAsync(OrderFileDTO dto)
        {
            var file = _mapper.Map<OrderFile>(dto);
            await _repository.AddAsync(file);
        }

        public async Task UpdateAsync(OrderFileDTO dto)
        {
            var file = _mapper.Map<OrderFile>(dto);
            await _repository.UpdateAsync(file);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
