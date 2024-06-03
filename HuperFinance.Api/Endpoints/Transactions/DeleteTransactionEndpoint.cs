using System.Security.Claims;
using HuperFinance.Api.Common.Api;
using HuperFinance.Core.Handlers;
using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Transactions;
using HuperFinance.Core.Responses;

namespace HuperFinance.Api.Endpoints.Transactions;

public class DeleteTransactionEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapDelete("/{id}", HandleAsync)
            .WithName("Transactions: Delete")
            .WithSummary("Exclui uma transação")
            .WithDescription("Exclui uma transação")
            .WithOrder(3)
            .Produces<Response<Transaction?>>();

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        long id)
    {
        var request = new DeleteTransactionRequest
        {
            UserId = ApiConfiguration.UserId,
            Id = id
        };

        var result = await handler.DeleteAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}