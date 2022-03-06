using ApprovalWorkflow.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApprovalWorkflow
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApprovalDefinition> ApprovalDefinitions { get; set; }
        public virtual DbSet<ApprovalInstance> ApprovalInstances { get; set; }
        public virtual DbSet<ApprovalHistory> ApprovalHistories { get; set; }
        public virtual DbSet<ApprovalRule> ApprovalRules { get; set; }
        public virtual DbSet<ApprovalStep> ApprovalSteps { get; set; }
        public virtual DbSet<ApprovalTracking> ApprovalTrackings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
