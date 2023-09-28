using UmbracoProject1.Busniess.ScheduleJobs;

namespace UmbracoProject1.Busniess.Registers
{
    public static class UmbracoBuilderHostedServiceExtensions
    {
        public static IUmbracoBuilder AddCustomHostedServices(this IUmbracoBuilder
        builder)
        {
            builder.Services.AddHostedService<TTImport>();
            return builder;
        }
    }
}
