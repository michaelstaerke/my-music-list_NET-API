using Microsoft.EntityFrameworkCore;
using music_list_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container (=> Abhängigkeitscontainer)
builder.Services.AddControllers();
builder.Services.AddDbContext<MusicListContext>(opt => 
  opt.UseInMemoryDatabase("MusicList"));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
