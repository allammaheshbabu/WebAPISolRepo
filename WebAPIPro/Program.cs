using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPIPro.DataAcesses.DataRepository;
using WebAPIPro.DataAcesses.IDataRepository;
using WebAPIPro.DB_Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QIS2Context> (options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConStrLocal")));
builder.Services.AddTransient<IDeptRepository, DeptRepository>();
builder.Services.AddTransient<IEmpRepository, EmpRepository>();
//builder.Services.AddSingleton<IDeptRepository, DeptRepository>();
//builder.Services.AddSingleton<IEmpRepository, EmpRepository>();
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
