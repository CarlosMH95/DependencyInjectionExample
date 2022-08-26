using DependencyInjectionExampleTP.Process;
using DependencyInjectionExampleTP.Process.Interfaces;

namespace DependencyInjectionExampleTP
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IEjecutarReq _req;

        public Worker(ILogger<Worker> logger, IEjecutarReq req)
        {
            _logger = logger;
            _req = req;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                //EjecutarReq req = new EjecutarReq();
                _req.ProcesarInformacion();
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}