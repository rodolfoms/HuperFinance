using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Transactions;
using HuperFinance.Core.Responses;

namespace HuperFinance.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
}