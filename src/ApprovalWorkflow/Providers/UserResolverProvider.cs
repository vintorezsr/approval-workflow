using ApprovalWorkflow.Abstractions;
using System.Collections.Concurrent;

namespace ApprovalWorkflow.Providers
{
    public class UserResolverProvider : IUserResolverProvider
    {
        protected readonly ConcurrentDictionary<string, IUserResolver> _userResolvers = new();

        public UserResolverProvider(IEnumerable<IUserResolver> userResolvers)
        {
            foreach(var userResolver in userResolvers)
            {
                _userResolvers[userResolver.GetType().Name] = userResolver;
            }
        }

        public IUserResolver GetUserResolver(string name)
        {
            return _userResolvers[name];
        }
    }
}
