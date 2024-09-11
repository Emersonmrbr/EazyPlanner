using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class Project(int projectId,
        string projectName,
        string description,
        string projectProgress,
        string completedTasks,
        string workedFromTotal,
        string mytrackedTime,
        string hoursWorked,
        string sProjectState,
        string hoursLeft,
        string budgetHours,
        string hoursBooked,
        decimal estimatedCost,
        decimal estimatedPrice,
        decimal estimatedBillableAmount,
        double hoursWorkedSeconds,
        string billingType,
        decimal unbilledAr,
        int? customerSupplierId,
        CustomerSupplier? customerSupplier,
        ICollection<People> projectInvolvedEmployes,
        ICollection<People> projectManagers,
        ICollection<People> projectMembers,
        ICollection<People> projectInvolvedGuests,
        CreateBase create)
    {
        public int ProjectId { get; private set; } = projectId;
        public required string ProjectName { get; set; } = projectName;
        public string Description { get; set; } = description;
        public string ProjectProgress { get; set; } = projectProgress;
        public string CompletedTasks { get; set; } = completedTasks;
        public string WorkedFromTotal { get; set; } = workedFromTotal;
        public string MytrackedTime { get; set; } = mytrackedTime;
        public string HoursWorked { get; set; } = hoursWorked;
        public string SProjectState { get; set; } = sProjectState;
        public string HoursLeft { get; set; } = hoursLeft;
        public string BudgetHours { get; set; } = budgetHours;
        public string HoursBooked { get; set; } = hoursBooked;
        public decimal EstimatedCost { get; set; } = estimatedCost;
        public decimal EstimatedPrice { get; set; } = estimatedPrice;
        public decimal EstimatedBillableAmount { get; set; } = estimatedBillableAmount;
        public double HoursWorkedSeconds { get; set; } = hoursWorkedSeconds;
        public string BillingType { get; set; } = billingType;
        public decimal UnbilledAr { get; set; } = unbilledAr;

        public int? CustomerSupplierId { get; set; } = customerSupplierId;
        public CustomerSupplier? CustomerSupplier { get; set; } = customerSupplier;

        public ICollection<People> ProjectInvolvedEmployes { get; private set; } = projectInvolvedEmployes;
        public ICollection<People> ProjectManagers { get; private set; } = projectManagers;
        public ICollection<People> ProjectMembers { get; private set; } = projectMembers;
        public ICollection<People> ProjectInvolvedGuests { get; private set; } = projectInvolvedGuests;

        public CreateBase Create { get; set; } = create;

    }
}
