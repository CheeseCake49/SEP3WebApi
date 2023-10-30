using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
using DataConnection.DAOs;
using DataConnection.JavaConnection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GrpcAdapter>();
builder.Services.AddScoped<ICenterDAO, CenterDAO>();
builder.Services.AddScoped<ICenterLogic, CenterLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();