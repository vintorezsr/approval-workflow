namespace ApprovalWorkflow.Abstraction
{
    public interface IUserResolver
    {
        Task<IEnumerable<IUser>> ResolveAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
