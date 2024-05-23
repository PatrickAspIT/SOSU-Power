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
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

//// Adds Role
//builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Role>, Repository<SOSU_Power_9000.Entities.Role>>();
//// Adds Resident
builder.Services.AddScoped<IRepository<Resident>, Repository<Resident>>();
//// Adds Employee
//builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Employee>, Repository<SOSU_Power_9000.Entities.Employee>>();
//// Adds CareCenter
//builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.CareCenter>, Repository<SOSU_Power_9000.Entities.CareCenter>>();
//// Adds Address
//builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Address>, Repository<SOSU_Power_9000.Entities.Address>>();

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
