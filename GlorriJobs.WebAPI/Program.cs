using FluentValidation.AspNetCore;
using GlorriJobs.Persistence.Contexts;
using GlorriJobs.Persistence.Implements.Repositories.Implementations;
using GlorriJobs.Persistence.Implements.Repositories.Interfaces;
using GlorriJobs.Persistence.Implements.Services.Implementations;
using GlorriJobs.Persistence.Implements.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GlorriJobsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
});

builder.Services.AddScoped<ICityRepository,CityRepository>();

builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
