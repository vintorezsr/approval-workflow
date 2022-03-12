namespace ApprovalWorkflow.Abstractions
{
    public interface IUserResolver
    {
        Task<IEnumerable<IUser>> ResolveAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
