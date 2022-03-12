namespace ApprovalWorkflow.Abstractions
{
    public interface IUserResolverProvider
    {
        IUserResolver GetUserResolver(string name);
    }
}
