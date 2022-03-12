using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalHistory : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public ApprovalAction Action { get; set; }
        public string? Notes { get; set; }
        public ApprovalInstance? ApprovalInstance { get; set; }
    }
}
