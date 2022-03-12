using ApprovalWorkflow.Entities;

namespace ApprovalWorkflow.Abstractions
{
    public interface IApprovalDefinitionService
    {
        Task<ApprovalDefinition> SaveDefinitionAsync(
            ApprovalDefinition approvalDefinition,
            CancellationToken cancellationToken = default);

        Task<ApprovalDefinition> DeleteDefinitionAsync(
            Guid id,
            CancellationToken cancellationToken = default);
    }
}
