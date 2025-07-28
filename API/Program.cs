using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();  // We will not be using this in this course.  -Nick

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(options => options.AllowAnyHeader()
                              .AllowAnyMethod()
                              .WithOrigins("http://localhost:4200", "https://localhost:4200"));

// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();  // We will not be using this in this course.  -Nick
// }

app.MapControllers();

app.Run();
