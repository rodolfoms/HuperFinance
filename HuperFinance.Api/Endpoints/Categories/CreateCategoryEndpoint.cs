using HuperFinance.Core.Responses;
using HuperFinance.Api.Common.Api;
using HuperFinance.Api;
using HuperFinance.Core.Handlers;
using HuperFinance.Core.Models;
using HuperFinance.Core.Requests.Categories;

namespace HuperFinance.Api.Endpoints.Categories;

public class CreateCategoryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/", HandleAsync)
            .WithName("Categories: Create")
            .WithSummary("Cria uma nova categoria")
            .WithDescription("Cria uma nova categoria")
            .WithOrder(1)
            .Produces<Response<Category?>>();

    private static async Task<IResult> HandleAsync(
        ICategoryHandler handler,
        CreateCategoryRequest request)
    {
        request.UserId = ApiConfiguration.UserId;
        var response = await handler.CreateAsync(request);

        //if (response.IsSucess)
        //    return Results.Ok();
        //Results.NotFound();

        //if ternario ??

        return response.IsSuccess
            ? TypedResults.Created($"v1/categories/{response.Data?.Id}", response)
            : TypedResults.BadRequest(response);
    }
}