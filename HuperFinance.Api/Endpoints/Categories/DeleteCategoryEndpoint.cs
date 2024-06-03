using System.Security.Claims;
using HuperFinance.Api.Common.Api;
using HuperFinance.Core.Handlers;
using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Categories;
using HuperFinance.Core.Responses;

namespace HuperFinance.Api.Endpoints.Categories
{
    public class DeleteCategoryEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
            => app.MapDelete("/{id}", HandleAsync)
                .WithName("Categories: Delete")
                .WithSummary("Exclui uma categoria")
                .WithDescription("Exclui uma categoria")
                .WithOrder(3)
                .Produces<Response<Category?>>();

        private static async Task<IResult> HandleAsync(
            //ClaimsPrincipal user, //Request User
            ICategoryHandler handler,
            long id)
        {
            var request = new DeleteCategoryRequest
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
}
