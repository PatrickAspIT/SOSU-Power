using Microsoft.EntityFrameworkCore;
using SOSU_Power_9000.DataAccess;
using SOSU_Power_9000.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Register repositories :

// Adds Task
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
// Adds Employee
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//// Adds Resident
builder.Services.AddScoped<IRepository<Resident>, Repository<Resident>>();

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
