using ApprovalWorkflow.Abstractions;
using ApprovalWorkflow.Collections;
using ApprovalWorkflow.Entities;
using ApprovalWorkflow.Exceptions;

namespace ApprovalWorkflow.Services
{
    public class ApprovalWorkflowService : IApprovalWorkflowService
    {
        private readonly ApplicationDbContext _dbContext;

        public ApprovalWorkflowService(IApplicationDbContextFactory applicationDbContextFactory)
        {
            _dbContext = applicationDbContextFactory.GetDbContext();
        }

        public async Task<ApprovalInstance> SubmitAsync(
            string approvalDefinitionName,
            Payload? payload = default,
            bool saveAsDraft = false,
            CancellationToken cancellationToken = default)
        {
            var approvalDefinition = GetApprovalDefinition(approvalDefinitionName);
            var approvalAction = saveAsDraft ? ApprovalAction.SaveAsDraft : ApprovalAction.Submit;
            var approvalInstance = CreateApprovalInstance(approvalDefinition, saveAsDraft);
            CreateHistory(approvalInstance, approvalAction);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return approvalInstance;
        }

        public async Task<bool> TriggerAsync(
            Guid instanceId,
            ApprovalAction approvalAction,
            Payload? payload = default,
            CancellationToken cancellationToken = default)
        {
            var approvalInstance = GetApprovalInstance(instanceId);
            UpdateApprovalInstance(approvalInstance, approvalAction, payload);
            CreateHistory(approvalInstance!, approvalAction);
            return await _dbContext.SaveChangesAsync(cancellationToken) > 0;
        }

        private ApprovalDefinition GetApprovalDefinition(string name)
        {
            var approvalDefinition = _dbContext.ApprovalDefinitions.FirstOrDefault(x => x.Name == name);

            if (approvalDefinition == null)
            {
                throw new ApprovalDefinitionNotFoundException(name);
            }

            return approvalDefinition;
        }

        private ApprovalInstance GetApprovalInstance(Guid instanceId)
        {
            var approvalInstance = _dbContext.ApprovalInstances.FirstOrDefault(x => x.Id == instanceId);

            if (approvalInstance == null)
            {
                throw new ApprovalInstanceNotFoundException(instanceId);
            }

            return approvalInstance!;
        }

        private ApprovalInstance CreateApprovalInstance(ApprovalDefinition approvalDefinition, bool saveAsDraft)
        {
            var status = saveAsDraft ? ApprovalStatus.Draft : ApprovalStatus.InProgress;
            var approvalInstance = new ApprovalInstance
            {
                InstanceNumber = "",
                Status = status,
                ApprovalDefinition = approvalDefinition
            };

            _dbContext.ApprovalInstances.Add(approvalInstance);

            return approvalInstance;
        }

        private void UpdateApprovalInstance(
            ApprovalInstance approvalInstance,
            ApprovalAction approvalAction,
            Payload? payload = default)
        {

        }

        private void CreateHistory(ApprovalInstance approvalInstance, ApprovalAction approvalAction)
        {
            var approvalHistory = new ApprovalHistory
            {
                Action = approvalAction,
                ApprovalInstance = approvalInstance
            };

            _dbContext.ApprovalHistories.Add(approvalHistory);
        }
    }
}
