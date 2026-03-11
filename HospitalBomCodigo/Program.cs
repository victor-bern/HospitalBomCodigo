using HospitalBomCodigo.Context;
using HospitalBomCodigo.Workers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddHostedService<SmsBackgroundWorker>();

using var host = builder.Build();

using var scope = host.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();


await host.RunAsync();
