using ApprovalWorkflow.Abstraction;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalStep : IEntity
    {
        public Guid Id { get; set; }
        public ICollection<ApprovalRule> ApprovalRules { get; set; } = new List<ApprovalRule>();
    }
}
