using App_Anime.Data;
using App_Anime.Repositories;
using App_Anime.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("App_AnimeContext") ?? throw new InvalidOperationException("Connection string 'App_AnimeContext' not found.")));

// Register AutoMapper
builder.Services.AddAutoMapper(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));

// Register Repositories and Services
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyMethod()
                  .AllowAnyHeader()
                  .SetIsOriginAllowed(origin => true) // allow any origin
                  .AllowCredentials());

builder.Services.AddCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
