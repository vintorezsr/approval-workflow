using ApprovalWorkflow.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ApprovalWorkflow.Runtime
{
    public class StartupRunner : IStartupRunner
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IEnumerable<IStartupTask> _startupTasks;

        public StartupRunner(IEnumerable<IStartupTask> startupTasks, IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            _startupTasks = startupTasks;
        }

        public async Task StartupAsync(CancellationToken cancellationToken = default)
        {
            foreach (var startupTaskType in _startupTasks)
            {
                using var scope = _scopeFactory.CreateScope();
                var startupTask = (IStartupTask)scope.ServiceProvider.GetRequiredService(startupTaskType.GetType());
                await startupTask.ExecuteAsync(cancellationToken);
            }
        }
    }
}
