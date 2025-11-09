using AutoMapper;
using Studio.Core.Interfaces.Repositories;
using Studio.Core.Interfaces.Services;
using Studio.Core.Services;
using Studio.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Studio.API.Mapping;
using Microsoft.Extensions.DependencyInjection;
using Studio.Infrastructure.Data;
var builder = WebApplication.CreateBuilder(args);

// Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories + Services
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAudioSampleRepository, AudioSampleRepository>();
builder.Services.AddScoped<IAudioSampleService, AudioSampleService>();


// AutoMapper
//builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddAutoMapper(typeof(Program));


// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowFrontend");
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
