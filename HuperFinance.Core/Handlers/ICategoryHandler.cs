using HuperFinance.Core.Models;
using HuperFinance.Core.Requests;
using HuperFinance.Core.Requests.Categories;
using HuperFinance.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeteleAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<Response<PagedResponse<List<Category?>>>> GetAllAsync(GetCategoryByIdRequest request);
    }
}
