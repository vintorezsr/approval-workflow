using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalTracking : IEntity
    {
        public Guid Id { get; set; }
        public ApprovalInstance ApprovalInstance { get; set; }
    }
}
