using Studio.Core.DTOs;
using Studio.Core.Entities;
using Studio.Core.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Core.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _repository;
        private readonly IMapper _mapper;

        public SubCategoryService(ISubCategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SubCategoryDTO>> GetAllAsync()
        {
            var subCategories = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<SubCategoryDTO>>(subCategories);
        }

        public async Task<SubCategoryDTO> GetByIdAsync(int id)
        {
            var subCategory = await _repository.GetByIdAsync(id);
            return _mapper.Map<SubCategoryDTO>(subCategory);
        }

        public async Task<IEnumerable<SubCategoryDTO>> GetByCategoryIdAsync(int categoryId)
        {
            var subCategories = await _repository.GetByCategoryIdAsync(categoryId);
            return _mapper.Map<IEnumerable<SubCategoryDTO>>(subCategories);
        }

        public async Task AddAsync(SubCategoryDTO dto)
        {
            var subCategory = _mapper.Map<SubCategory>(dto);
            await _repository.AddAsync(subCategory);
        }

        public async Task UpdateAsync(SubCategoryDTO dto)
        {
            var subCategory = _mapper.Map<SubCategory>(dto);
            await _repository.UpdateAsync(subCategory);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
