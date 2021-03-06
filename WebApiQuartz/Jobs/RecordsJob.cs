using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System.Threading.Tasks;

namespace WebApiQuartz.Jobs
{
    public class RecordsJob : IJob
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public RecordsJob(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            using var scope = _serviceScopeFactory.CreateScope();
            var provider = scope.ServiceProvider;

            var recordService = provider.GetRequiredService<RecordSevice>();

            await recordService.AddRecord("Message from Job");
        }
    }
}
