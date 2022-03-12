using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalRule : IEntity
    {
        public Guid Id { get; set; }
        public string Expression { get; set; } = default!;
    }
}
