using ApprovalWorkflow.Abstraction;

namespace ApprovalWorkflow.Entities
{
    public enum ApprovalStatus
    {
        Draft,
        InProgress,
        Cancelled,
        Rejected,
        Revised,
        Expired,
        Completed
    }
}
