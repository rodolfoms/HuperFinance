using HuperFinance.Core.Models;
using HuperFinance.Core.Requests;
using HuperFinance.Core.Requests.Transactions;
using HuperFinance.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuperFinance.Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<Response<Category?>> CreateAsync(CreateTransactionRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateTransactionRequest request);
        Task<Response<Category?>> DeteleAsync(DeleteTransactionRequest request);
        Task<Response<Category?>> GetByIdAsync(GetTransactionByIdRequest request);
        Task<Response<PagedResponse<List<Transaction?>>>> GetByPeriodAsync(GetTransactionByPeriodRequest request);
    }
}
