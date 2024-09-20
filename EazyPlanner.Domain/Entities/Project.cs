using EazyPlanner.Domain.Bases;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
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

        public int? CustomerSupplierId { get; private set; } = 0;
        public CustomerSupplier? CustomerSupplier { get; private set; } = new(0,string.Empty,string.Empty);

        public ICollection<People>? InvolvedEmployes { get; private set; } = [];
        public ICollection<People>? InvolvedGuests { get; private set; } = [];
        public ICollection<People>? Managers { get; private set; } = [];
        public ICollection<People>? Members { get; private set; } = [];
        public ICollection<Chore>? Chores { get; private set; } = [];

    }
}
