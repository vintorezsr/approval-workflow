namespace ApprovalWorkflow.Abstraction
{
    public interface IStartupRunner
    {
        Task StartupAsync(CancellationToken cancellationToken = default);
    }
}
