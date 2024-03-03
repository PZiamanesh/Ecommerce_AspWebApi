using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// controller services
builder.Services.AddControllers();

// swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ef core
builder.Services.AddDbContext<EFcoreContext>(ops =>
{
    ops.UseSqlServer(builder.Configuration["ConnectionStrings:EfCoreConn"]);
});







var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// seed data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<EFcoreContext>();
    var logger = scope.ServiceProvider.GetRequiredService<ILoggerFactory>();

    await GenerateFakeData.SeedDataAsync(context, logger);
    await context.Database.MigrateAsync();
}

app.Run();
