using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OpenApi;

namespace Library.Api.Endpoints;

public static class BooksEndpoints 
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/books").WithOpenApi();


        group.MapGet("", async (LibraryDb db) => await GetBooks(db));
    }
}
