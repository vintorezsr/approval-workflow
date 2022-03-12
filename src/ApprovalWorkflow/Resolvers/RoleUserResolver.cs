using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Resolvers
{
    public class RoleUserResolver : UserResolverBase
    {
        public RoleUserResolver(IApplicationDbContextFactory applicationDbContextFactory)
            : base(applicationDbContextFactory)
        {
        }

        public override Task<IEnumerable<IUser>> ResolveAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
