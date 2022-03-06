using ApprovalWorkflow.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace ApprovalWorkflow
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public ApplicationDbContextFactory(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public ApplicationDbContext GetDbContext() => _dbContextFactory.CreateDbContext();
    }
}
