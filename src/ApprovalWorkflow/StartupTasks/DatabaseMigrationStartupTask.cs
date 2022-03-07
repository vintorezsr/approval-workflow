using ApprovalWorkflow.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace ApprovalWorkflow.StartupTasks
{
    public class DatabaseMigrationStartupTask : IStartupTask
    {
        private readonly IApplicationDbContextFactory _applicationDbContextFactory;

        public DatabaseMigrationStartupTask(IApplicationDbContextFactory applicationDbContextFactory)
        {
            _applicationDbContextFactory = applicationDbContextFactory;
        }

        public async Task ExecuteAsync(CancellationToken cancellationToken = default)
        {
            using var dbContext = _applicationDbContextFactory.GetDbContext();
            await dbContext.Database.MigrateAsync(cancellationToken);
            await dbContext.DisposeAsync();
        }
    }
}
