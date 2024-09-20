using EazyPlanner.Domain.Bases;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
{
    public class Chore(int id, string name, string number)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Number { get; set; } = number;
        public string? Description { get; set; } = string.Empty;

        public BillingType BillingType { get; set; } = BillingType.TimeBased;
        public bool Completed { get; set; } = false;
        public bool Invoced { get; set; } = true;
        public DateTime? DueDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; } = DateTime.UtcNow;
        public DateTime? StartDate { get; set; } = DateTime.UtcNow;
        public decimal? EstimateBillableAmount { get; set; } = 0;
        public decimal? EstimateCost { get; set; } = 0;
        public decimal? HourlyRate { get; set; } = 0;
        public double? EstimateHours { get; set; } = 0;
        public double? HoursLeft { get; set; } = 0;
        public double? HoursWorked { get; set; } = 0;
        public double? ProgressStatus { get; set; } = 0;
        public double? WorkedFromTotal { get; set; } = 0;
        public string? Priority { get; set; } = string.Empty;
        public CreateBase? Create { get; set; } = new();

        public int? ProjectId { get; private set; } = 0;
        public Project? Project { get; private set; } = new(0, string.Empty, string.Empty);

        public ICollection<People>? AssignedTo { get; set; } = [];
        public ICollection<People>? Followers { get; set; } = [];
        public ICollection<TimeEntrie>? TimeEntries { get; set; } = [];
        public ICollection<string>? ChoreList { get; set; } = [];
    }
}
