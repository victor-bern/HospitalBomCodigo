using HospitalBomCodigo.Context;
using HospitalBomCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
                using var scope = _services.CreateScope();

                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                var pendingExams = await context.Exams
                    .Where(e => e.Status == ExamStatus.Released && !e.NotificationSent)
                    .OrderBy(e => e.Status)
                    .Include(x => x.Patient)
                    .Take(20)
                    .ToListAsync(stoppingToken);

                _logger.LogInformation("Foram encontrados {count} exames liberados para notificação.", pendingExams.Count);

                foreach (var exam in pendingExams)
                {
                    _logger.LogInformation(
                        "SMS Enviado: Prezado(a) cliente, {FirstName}, os resultados dos seus exames estão disponíveis para retirada. \n" +
                        "[Tipo: {Type} | Descrição: {Description} | Liberado em: {ReleasedAt} | Enviado para: {Number}]",
                        exam.Patient.Name,
                        exam.Type,
                        exam.Description,
                        exam.ResultReleasedAt,
                        exam.Patient.PhoneNumber
                        );

                    exam.NotificationSent = true;
                }

                await context.SaveChangesAsync(stoppingToken);

                await Task.Delay(TimeSpan.FromSeconds(60), stoppingToken);
            }
        }
    }
}
