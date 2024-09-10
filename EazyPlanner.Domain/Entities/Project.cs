using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class Project
    {
        public int ProjectId { get; private set; }
        public required string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectStatus { get; set; }

        public int? CustomerSupplierId { get; set; }
        public CustomerSupplier? CustomerSupplier { get; set; }

        public string CompletedTasks { get; set; }
        public string WorkedFromTotal { get; set; }
        public string MytrackedTime { get; set; }
        public string HoursWorked { get; set; }
        public string Status { get; set; }
        public string HoursLeft { get; set; }
        public string BudgetHours { get; set; }
        public string HoursBooked { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal EstimatedPrice { get; set; }
        public string BillingType { get; set; }
        public decimal UnbilledAr { get; set; }

        public CreateBase Create { get; set; } = new CreateBase(string.Empty, DateTime.Now, string.Empty, DateTime.Now);
        public ICollection<People> People { get; private set; } = [];


    }
}
