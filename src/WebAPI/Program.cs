using Infrastructure.Presistence;
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

    try
    {
        await SeedData.SeedDataAsync(context);
        await context.Database.MigrateAsync();
    }
    catch (Exception exp)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
        logger.LogError(exp, "error occured during migration.");
    }
}

app.Run();
