using Microsoft.EntityFrameworkCore;
using NewsBlogAPI.Data;
using NewsBlogAPI.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Dependency Injection
builder.Services.AddScoped<IUserReposotory, UserReposotory>();
builder.Services.AddScoped<JwtService>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();

//DBContext
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DevConnection")
));

//Add Cors
builder.Services.AddCors(options => options.AddPolicy(
    "AllowOrigin",
    builder =>
    {
        builder.WithOrigins("http://localhost:3000", "http://localhost:5118").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    }
    ));

var app = builder.Build();

//Use Cors
app.UseCors("AllowOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
