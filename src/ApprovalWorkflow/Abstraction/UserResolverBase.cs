namespace ApprovalWorkflow.Abstraction
{
    public abstract class UserResolverBase : IUserResolver
    {
        protected readonly IApplicationDbContextFactory _applicationDbContextFactory;
        public ApplicationDbContext ApplicationDbContext => _applicationDbContextFactory.GetDbContext();

        public UserResolverBase(IApplicationDbContextFactory applicationDbContextFactory)
        {
            _applicationDbContextFactory = applicationDbContextFactory;
        }

        public abstract Task<IEnumerable<IUser>> ResolveAsync(Guid id, CancellationToken cancellationToken);
    }
}
