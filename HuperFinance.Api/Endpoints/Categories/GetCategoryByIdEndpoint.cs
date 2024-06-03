using System.Security.Claims;
using HuperFinance.Api.Common.Api;
using HuperFinance.Core.Handlers;
using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Categories;
using HuperFinance.Core.Responses;
using Microsoft.Extensions.Configuration;

namespace HuperFinance.Api.Endpoints.Categories
{
    public class GetCategoryByIdEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
            => app.MapGet("/{id}", HandleAsync)
                .WithName("Categories: Get By Id")
                .WithSummary("Recupera uma categoria")
                .WithDescription("Recupera uma categoria")
                .WithOrder(4)
                .Produces<Response<Category?>>();

        private static async Task<IResult> HandleAsync(
            //ClaimsPrincipal user, //Request User
            ICategoryHandler handler,
            long id)
        {
            var request = new GetCategoryByIdRequest
            {
                UserId = ApiConfiguration.UserId,
                Id = id
            };

            var result = await handler.GetByIdAsync(request);
            return result.IsSuccess
                ? TypedResults.Ok(result)
                : TypedResults.BadRequest(result);
        }
    }
}