using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Library.Api.Models;
using Library.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Use InMemoryDatabase for the purpose of this example
builder.Services.AddDbContext<LibraryDb>(opt => opt.UseInMemoryDatabase("Library"));

var app = builder.Build();

BooksEndpoints.RegisterEndpoints(app);

app.Run();
