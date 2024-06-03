using System.Security.Claims;
using HuperFinance.Api.Common.Api;
using HuperFinance.Core.Handlers;
using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Categories;
using HuperFinance.Core.Responses;
using Microsoft.Extensions.Configuration;

namespace HuperFinance.Api.Endpoints.Categories
{
    public class UpdateCategoryEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
            => app.MapPut("/{id}", HandleAsync)
                .WithName("Categories: Update")
                .WithSummary("Atualiza uma categoria")
                .WithDescription("Atualiza uma categoria")
                .WithOrder(2)
                .Produces<Response<Category?>>();

        private static async Task<IResult> HandleAsync(
            //ClaimsPrincipal user, //Request User
            ICategoryHandler handler,
            UpdateCategoryRequest request,
            long id)
        {
            request.UserId = ApiConfiguration.UserId;
            request.Id = id;

            var result = await handler.UpdateAsync(request);
            return result.IsSuccess
                ? TypedResults.Ok(result)
                : TypedResults.BadRequest(result);
        }
    }
}