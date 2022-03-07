using ApprovalWorkflow.Abstraction;
using ApprovalWorkflow.HostedServices;
using ApprovalWorkflow.Providers;
using ApprovalWorkflow.Runtime;
using ApprovalWorkflow.Services;
using ApprovalWorkflow.StartupTasks;
using Microsoft.Extensions.DependencyInjection;

namespace ApprovalWorkflow.Extensions
{
    public static class ApprovalWorkflowExtensions
    {
        public static IServiceCollection AddApprovalWorkflow(this IServiceCollection services)
        {
            services.AddSingleton<IApplicationDbContextFactory, ApplicationDbContextFactory>();
            services.AddSingleton<IApprovalWorkflowFactory, ApprovalWorkflowFactory>();
            services.AddSingleton<IUserResolverProvider, UserResolverProvider>();
            services.AddTransient<IApprovalWorkflowService, ApprovalWorkflowService>();
            services.AddScoped<IStartupTask, DatabaseMigrationStartupTask>();
            services.AddScoped<IStartupRunner, StartupRunner>();
            services.AddHostedService<StartupHostedService>();

            return services;
        }

        public static IServiceCollection AddUserResolverFrom<TType>(this IServiceCollection services)
            where TType : class
        {
            var assembly = typeof(TType).Assembly;
            var userResolverTypes = typeof(IUserResolver);
            var types = assembly.GetAllWithInterface(userResolverTypes);

            foreach (var type in types)
            {
                services.AddTransient(userResolverTypes, type);
            }

            return services;
        }
    }
}
