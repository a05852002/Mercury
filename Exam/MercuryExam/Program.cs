using MercuryExam.Models;
using MercuryExam.Service;
using MercuryExam.Service.Impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//資料庫連線資訊抓取
builder.Services.AddDbContext<MercuryExamContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("WebDatabase")));

// 註冊服務
builder.Services.AddScoped<IMyOfficeACPDService, MyOfficeACPDService>();
builder.Services.AddScoped<IMyofficeExcuteionLogService, MyOfficeExcuteionLogService>();

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
