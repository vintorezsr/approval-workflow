namespace ApprovalWorkflow.Exceptions
{
    public class ApprovalInstanceNotFoundException : Exception
    {
        public ApprovalInstanceNotFoundException(Guid instanceId)
            : base($"Approval instance with id `{instanceId}` was not found")
        {
        }
    }
}
