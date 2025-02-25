using EazyPlanner.Data.Bases;
using EazyPlanner.Data.Enums;

namespace EazyPlanner.Data.Entities
{
    public class Project(int id, string name, string number)
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public string Number { get; set; } = number;
        public string? Description { get; set; } = string.Empty;

        public BillingMethod BillingMethod { get; set; } = BillingMethod.TimeMaterials;
        public BillingPriority? BillingPriority { get; set; } = Enums.BillingPriority.CompanyHourlyRate;
        public decimal? EstimatedPrice { get; set; } = 0;
        public decimal? UnbilledAr { get; set; } = 0;
        public double? BudgetHours { get; set; } = 0;
        public double? HoursWorkedSeconds { get; set; } = 0;
        public double? Progress { get; set; } = 0;
        public HoursEstimate? HoursEstimate { get; set; } = Enums.HoursEstimate.AdjustedAutomatically;
        public double? HoursBooked { get; set; } = 0;
        public double? HoursWorked { get; set; } = 0;
        public string? State { get; set; } = string.Empty;

        public CreateBase? Create { get; set; } = new();

        public int? CompanyAccountId { get; private set; } = 0;
        public CompanyAccount? CompanyAccount { get; private set; } = new(0,string.Empty,string.Empty);

        public ICollection<PersonAccount>? InvolvedEmployes { get; private set; } = [];
        public ICollection<PersonAccount>? InvolvedGuests { get; private set; } = [];
        public ICollection<PersonAccount>? Managers { get; private set; } = [];
        public ICollection<PersonAccount>? Members { get; private set; } = [];
        public ICollection<Chore>? Chores { get; private set; } = [];

    }
}
