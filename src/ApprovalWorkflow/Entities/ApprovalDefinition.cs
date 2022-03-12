using ApprovalWorkflow.Abstractions;

namespace ApprovalWorkflow.Entities
{
    public class ApprovalDefinition : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<ApprovalStep> ApprovalSteps { get; set; } = new List<ApprovalStep>();
    }
}
