using HospitalBomCodigo.Context;
using HospitalBomCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HospitalBomCodigo.Workers
{
    public class SmsBackgroundWorker : BackgroundService
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<SmsBackgroundWorker> _logger;


        public SmsBackgroundWorker(IServiceProvider services, ILogger<SmsBackgroundWorker> logger)
        {
            _services = services;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker varrendo exames liberados às: {time}", DateTimeOffset.Now);

                using var scope = _services.CreateScope();

                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    var pendingExams = await context.Exams
                        .Where(e => e.Status == ExamStatus.Released && !e.NotificationSent)
                        .Take(20)
                        .OrderBy(e => e.Status)
                        .ToListAsync(stoppingToken);

                    _logger.LogInformation("Foram encontrados {count} exames liberados para notificação.", pendingExams.Count);

                foreach (var exam in pendingExams)
                    {
                    _logger.LogInformation(
                        "SMS Enviado: Prezado cliente, os resultados dos seus exames estão disponíveis para retirada. \n" +
                        "[Tipo: {Type} | Descrição: {Description} | Liberado em: {ReleasedAt}]",
                        exam.Type,
                        exam.Description,
                        exam.ResultReleasedAt);

                    exam.NotificationSent = true;
                    exam.ResultReleasedAt  = DateTime.UtcNow;
                }

                    await context.SaveChangesAsync(stoppingToken);

                await Task.Delay(TimeSpan.FromSeconds(60), stoppingToken);
            }
        }
    }
}
