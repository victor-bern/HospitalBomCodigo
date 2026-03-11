using HospitalBomCodigo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HospitalBomCodigo.Workers
{
    public class ProcessExamBackgroundWorker : BackgroundService
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<ProcessExamBackgroundWorker> _logger;


        public ProcessExamBackgroundWorker(IServiceProvider services, ILogger<ProcessExamBackgroundWorker> logger)
        {
            _services = services;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                TimeZoneInfo brazilZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");

                _logger.LogInformation("ProcessExamBackgroundWorker is running at: {time}", DateTime.Now);
                using var scope = _services.CreateScope();

                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();


                var examsPending = await context.Exams
                    .Where(e => e.Status == Models.ExamStatus.Pending)
                    .OrderBy(e => e.Status)
                    .Take(20)
                    .ToListAsync(stoppingToken);


                foreach (var exam in examsPending)
                {
                    await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
                    exam.Status = Models.ExamStatus.Released;
                    exam.ResultReleasedAt = DateTime.Now;
                }

                try
                {
                    await context.SaveChangesAsync(stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message, ex);
                }


                await Task.Delay(TimeSpan.FromSeconds(120), stoppingToken);
            }
        }
    }
}
