using ApprovalWorkflow.Collections;
using ApprovalWorkflow.Entities;

namespace ApprovalWorkflow.Abstractions
{
    public interface IApprovalWorkflowService
    {
        Task<ApprovalInstance> SubmitAsync(
            string approvalDefinitionName,
            Payload? payload = default,
            bool saveAsDraft = false,
            CancellationToken cancellationToken = default);

        Task<bool> TriggerAsync(
            Guid instanceId,
            ApprovalAction approvalAction,
            Payload? payload = default,
            CancellationToken cancellationToken = default);
    }
}
