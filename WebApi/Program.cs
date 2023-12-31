using System.Text;
using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
using DataConnection.DAOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Sep3WebApi.Services;
using Shared.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICenterDAO, CenterDAO>();
builder.Services.AddScoped<ICenterLogic, CenterLogic>();
builder.Services.AddScoped<ICourtDAO, CourtDAO>();
builder.Services.AddScoped<ICourtLogic, CourtLogic>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserDAO, UserDAO>();
builder.Services.AddScoped<IUserLogic, UserLogic>();
builder.Services.AddScoped<IBookingDAO, BookingDAO>();
builder.Services.AddScoped<IBookingLogic, BookingLogic>();
builder.Services.AddScoped<IBookingAddOnDAO, BookingAddOnDAO>();
builder.Services.AddScoped<IBookingAddOnLogic, BookingAddOnLogic>();
builder.Services.AddScoped<ITimeSlotDAO, TimeSlotDAO>();
builder.Services.AddScoped<ITimeSlotLogic, TimeSlotLogic>();

AuthorizationPolicies.AddPolicies(builder.Services);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

