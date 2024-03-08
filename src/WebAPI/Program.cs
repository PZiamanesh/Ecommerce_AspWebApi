using Application.Contracts;
using Application.Features.Products.Queries;
using Domain.Entities;
using Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

#region application services



#endregion


#region infrastructure services

// ef core
builder.Services.AddDbContext<EFcoreContext>(ops =>
{
    ops.UseSqlServer(builder.Configuration["ConnectionStrings:EfCoreConn"]);
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#endregion


#region WebUI services

// controller services
builder.Services.AddControllers();

// swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// mediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllProductsQuery>());


#endregion


#region request pipline

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

#endregion

