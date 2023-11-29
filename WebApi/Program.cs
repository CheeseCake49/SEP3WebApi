using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
using DataConnection.DAOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICenterDAO, CenterDAO>();
builder.Services.AddScoped<ICenterLogic, CenterLogic>();
builder.Services.AddScoped<ICourtDAO, CourtDAO>();
builder.Services.AddScoped<ICourtLogic, CourtLogic>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

