using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SimurghEngine.API.Data;
using SimurghEngine.API.Interfaces;
using SimurghEngine.API.Services;
using SimurghEngine.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var provider= builder.Services.BuildServiceProvider();
var _config= provider.GetRequiredService<IConfiguration>();


builder.Services.AddApplicationServices(_config);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddIdentityServices(_config);






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
