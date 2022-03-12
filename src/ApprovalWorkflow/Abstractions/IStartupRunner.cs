namespace ApprovalWorkflow.Abstractions
{
    public interface IStartupRunner
    {
        Task StartupAsync(CancellationToken cancellationToken = default);
    }
}
