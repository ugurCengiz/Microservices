﻿

using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICategoryService
    {

        Task<Response<List<Category>>> GetAllAsync();
        Task<Response<CategoryCreateDto>> CreateAsync(CategoryCreateDto categoryCreateDto);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
