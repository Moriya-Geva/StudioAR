using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class FAQService : IFAQService
    {
        private readonly IFAQRepository _repository;
        private readonly IMapper _mapper;

        public FAQService(IFAQRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FAQDTO>> GetAllAsync()
        {
            var faqs = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<FAQDTO>>(faqs);
        }

        public async Task<FAQDTO> GetByIdAsync(int id)
        {
            var faq = await _repository.GetByIdAsync(id);
            return _mapper.Map<FAQDTO>(faq);
        }

        public async Task<IEnumerable<FAQDTO>> GetByCategoryIdAsync(int categoryId)
        {
            var faqs = await _repository.GetByCategoryIdAsync(categoryId);
            return _mapper.Map<IEnumerable<FAQDTO>>(faqs);
        }

        public async Task AddAsync(FAQDTO dto)
        {
            var faq = _mapper.Map<FAQ>(dto);
            await _repository.AddAsync(faq);
        }

        public async Task UpdateAsync(FAQDTO dto)
        {
            var faq = _mapper.Map<FAQ>(dto);
            await _repository.UpdateAsync(faq);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
