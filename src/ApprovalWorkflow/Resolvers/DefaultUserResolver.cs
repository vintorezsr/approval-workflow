using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Resolvers
{
    public class DefaultUserResolver : UserResolverBase
    {
        public DefaultUserResolver(IApplicationDbContextFactory applicationDbContextFactory)
            : base(applicationDbContextFactory)
        {
        }

        public override Task<IEnumerable<IUser>> ResolveAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
