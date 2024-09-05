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

//��Ʈw�s�u��T���
builder.Services.AddDbContext<MercuryExamContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("WebDatabase")));

// ���U�A��
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
