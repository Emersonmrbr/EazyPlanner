using EazyPlanner.Domain.Base;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
{
    public class Project
    {
        public BillingType TaskBillingType { get; set; }
        public bool TaskCompleted { get; set; }
        public CreateBase ProjectCreate { get; set; }
        public CustomerSupplier? CustomerSupplier { get; set; }
        public decimal EstimatedPrice { get; set; }
        public decimal TaskEstimateBillableAmount { get; set; }
        public decimal TaskEstimateCost { get; set; }
        public decimal UnbilledAr { get; set; }
        public double HoursWorkedSeconds { get; set; }
        public double ProjectProgress { get; set; }
        public double TaskHoursLeft { get; set; }
        public double TaskHoursWorked { get; set; }
        public double TaskWorkedTotal { get; set; }
        public ICollection<People> ProjectInvolvedEmployes { get; private set; }
        public ICollection<People> ProjectInvolvedGuests { get; private set; }
        public ICollection<People> ProjectManagers { get; private set; }
        public ICollection<People> ProjectMembers { get; private set; }
        public int ProjectId { get; private set; }
        public int? CustomerSupplierId { get; set; }
        public required string ProjectName { get; set; }
        public string ProjectBudgetHours { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectHoursBooked { get; set; }
        public string ProjectHoursWorked { get; set; }
        public string ProjectState { get; set; }

    }
}
