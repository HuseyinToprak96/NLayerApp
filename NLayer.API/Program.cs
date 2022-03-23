using Microsoft.EntityFrameworkCore;
using NLayerCore.Repositories;
using NLayerCore.Services;
using NLayerCore.UnitOfWork;
using NLayerRepository;
using NLayerRepository.Repository;
using NLayerRepository.UnitOfWork;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();//alacaðý interfaces
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
    option.MigrationsAssembly(Assembly.GetAssembly(typeof (AppDbContext)).GetName().Name);//Bu sayede AppDbContext in adý deðiþince otomatik olarak adýný çekicek
    });

});
//Baðlantý oluþturuldu API kýsmýnda uygulamayý haberdar etmek gerekiyor.
//Bunun için

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
