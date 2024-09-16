using EazyPlanner.Domain.Base;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
{
    public class Project(int id, string name, string number, string? description, BillingMethod billingMethod, BillingPriority? billingPriority, decimal? estimatedPrice, decimal? unbilledAr, double? budgetHours, double? hoursWorkedSeconds, double? progress, HoursEstimate? hoursEstimate, double? hoursBooked, double? hoursWorked, string? state, CreateBase? create, int? customerSupplierId, CustomerSupplier? customerSupplier, ICollection<People>? involvedEmployes, ICollection<People>? involvedGuests, ICollection<People>? managers, ICollection<People>? members, ICollection<Chore>? chores)
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public string Number { get; set; } = number;
        public string? Description { get; set; } = description;

        public BillingMethod BillingMethod { get; set; } = billingMethod;
        public BillingPriority? BillingPriority { get; set; } = billingPriority;
        public decimal? EstimatedPrice { get; set; } = estimatedPrice;
        public decimal? UnbilledAr { get; set; } = unbilledAr;
        public double? BudgetHours { get; set; } = budgetHours;
        public double? HoursWorkedSeconds { get; set; } = hoursWorkedSeconds;
        public double? Progress { get; set; } = progress;
        public HoursEstimate? HoursEstimate { get; set; } = hoursEstimate;
        public double? HoursBooked { get; set; } = hoursBooked;
        public double? HoursWorked { get; set; } = hoursWorked;
        public string? State { get; set; } = state;

        public CreateBase? Create { get; set; } = create;

        public int? CustomerSupplierId { get; private set; } = customerSupplierId;
        public CustomerSupplier? CustomerSupplier { get; private set; } = customerSupplier;

        public ICollection<People>? InvolvedEmployes { get; private set; } = involvedEmployes;
        public ICollection<People>? InvolvedGuests { get; private set; } = involvedGuests;
        public ICollection<People>? Managers { get; private set; } = managers;
        public ICollection<People>? Members { get; private set; } = members;
        public ICollection<Chore>? Chores { get; private set; } = chores;

    }
}
