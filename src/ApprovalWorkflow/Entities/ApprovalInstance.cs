using ApprovalWorkflow.Abstraction;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalInstance : IEntity
    {
        public Guid Id { get; set; }
        public Guid? CorrelationId { get; set; }
        public string? InstanceNumber { get; set; }
        public ApprovalStatus Status { get; set; }
        public string? StatusText { get; set; }
    }
}
