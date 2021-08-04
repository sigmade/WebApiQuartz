using Quartz;
using System;

namespace WebApiQuartz.Jobs
{
    public class RecordsScheduleService : JobScheduleService<RecordsJob>
    {
        public RecordsScheduleService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override TriggerBuilder ConfigureTrigger(TriggerBuilder triggerBuilder)
        {
            return triggerBuilder.WithSimpleSchedule(x => x.WithIntervalInMinutes(3).RepeatForever());
        }
    }
}
