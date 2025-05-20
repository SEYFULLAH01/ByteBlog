using AutoMapper;
using ByteBlog.Data.UnitOfWorks;
using ByteBlog.Entity.DTOs.Categories;
using ByteBlog.Entity.Entities;
using ByteBlog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBlog.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public Task<List<CategoryDto>> GetAllCategoriesDeleted()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }

        public Task<List<CategoryDto>> GetAllCategoriesNonDeletedTake24()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<string> SafeDeleteCategoryAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UndoDeleteCategoryAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
