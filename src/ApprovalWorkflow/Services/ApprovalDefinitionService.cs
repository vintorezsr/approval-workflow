using ApprovalWorkflow.Abstractions;
using ApprovalWorkflow.Entities;
using ApprovalWorkflow.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ApprovalWorkflow.Services
{
    public class ApprovalDefinitionService : IApprovalDefinitionService
    {
        private readonly ApplicationDbContext _dbContext;

        public ApprovalDefinitionService(IApplicationDbContextFactory applicationDbContextFactory)
        {
            _dbContext = applicationDbContextFactory.GetDbContext();
        }

        public async Task<ApprovalDefinition> SaveDefinitionAsync(
            ApprovalDefinition approvalDefinition,
            CancellationToken cancellationToken = default)
        {
            _dbContext.ApprovalDefinitions.Update(approvalDefinition);
            await _dbContext.SaveChangesAsync(cancellationToken);
            _dbContext.Entry(approvalDefinition).State = EntityState.Detached;
            return approvalDefinition;
        }

        public async Task<ApprovalDefinition> DeleteDefinitionAsync(
            Guid id,
            CancellationToken cancellationToken = default)
        {
            var approvalDefinition = GetApprovalDefinition(id);
            _dbContext.ApprovalDefinitions.Remove(approvalDefinition);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return approvalDefinition;
        }

        private ApprovalDefinition GetApprovalDefinition(Guid id)
        {
            var approvalDefinition = _dbContext.ApprovalDefinitions.FirstOrDefault(x => x.Id == id);

            if (approvalDefinition == null)
            {
                throw new ApprovalDefinitionNotFoundException(id);
            }

            return approvalDefinition;
        }
    }
}
