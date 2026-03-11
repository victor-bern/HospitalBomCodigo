using HospitalBomCodigo.Context;
using HospitalBomCodigo.Workers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore.Infrastructure", LogLevel.Warning);

builder.Services.AddHostedService<ProcessExamBackgroundWorker>();
builder.Services.AddHostedService<SmsBackgroundWorker>();

using var host = builder.Build();

using var scope = host.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();


await host.RunAsync();
