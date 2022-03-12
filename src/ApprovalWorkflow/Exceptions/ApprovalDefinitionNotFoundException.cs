namespace ApprovalWorkflow.Exceptions
{
    public class ApprovalDefinitionNotFoundException : Exception
    {
        public ApprovalDefinitionNotFoundException(string name)
            : base($"Approval definition with name `{name}` was not found")
        {
        }

        public ApprovalDefinitionNotFoundException(Guid id)
            : base($"Approval definition with id `{id}` was not found")
        {
        }
    }
}
