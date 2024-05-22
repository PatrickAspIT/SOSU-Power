using Microsoft.EntityFrameworkCore;
using SOSU_Power_9000.DataAccess;

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
builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Task>, Repository<SOSU_Power_9000.Entities.Task>>();
// Adds Role
builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Role>, Repository<SOSU_Power_9000.Entities.Role>>();
// Adds Resident
builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Resident>, Repository<SOSU_Power_9000.Entities.Resident>>();
// Adds Medicine
builder.Services.AddScoped<IRepository<SOSU_Power_9000.Entities.Medicine>, Repository<SOSU_Power_9000.Entities.Medicine>>();

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
