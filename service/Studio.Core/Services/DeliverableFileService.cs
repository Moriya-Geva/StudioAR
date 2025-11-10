using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class DeliverableFileService : IDeliverableFileService
    {
        private readonly IDeliverableFileRepository _repository;
        private readonly IMapper _mapper;

        public DeliverableFileService(IDeliverableFileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DeliverableFileDTO>> GetAllAsync()
        {
            var files = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<DeliverableFileDTO>>(files);
        }

        public async Task<DeliverableFileDTO> GetByIdAsync(int id)
        {
            var file = await _repository.GetByIdAsync(id);
            return _mapper.Map<DeliverableFileDTO>(file);
        }

        public async Task<IEnumerable<DeliverableFileDTO>> GetByOrderIdAsync(int orderId)
        {
            var files = await _repository.GetByOrderIdAsync(orderId);
            return _mapper.Map<IEnumerable<DeliverableFileDTO>>(files);
        }

        public async Task AddAsync(DeliverableFileDTO dto)
        {
            var file = _mapper.Map<DeliverableFile>(dto);
            await _repository.AddAsync(file);
        }

        public async Task UpdateAsync(DeliverableFileDTO dto)
        {
            var file = _mapper.Map<DeliverableFile>(dto);
            await _repository.UpdateAsync(file);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
