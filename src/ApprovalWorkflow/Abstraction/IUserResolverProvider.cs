namespace ApprovalWorkflow.Abstraction
{
    public interface IUserResolverProvider
    {
        IUserResolver GetUserResolver(string name);
    }
}
