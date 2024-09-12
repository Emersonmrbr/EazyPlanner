using EazyPlanner.Domain.Base;
using EazyPlanner.Domain.Enums;

namespace EazyPlanner.Domain.Entities
{
    public class ProjectTask(int id, string name, string number, string? description, BillingType billingType, bool completed, bool invoced, DateTime? dueDate, DateTime? endDate, DateTime? startDate, decimal? estimateBillableAmount, decimal? estimateCost, decimal? hourlyRate, double? estimateHours, double? hoursLeft, double? hoursWorked, double? progressStatus, double? workedFromTotal, string? priority, CreateBase? create, int? projectId, Project? project, ICollection<People>? assignedTo, ICollection<People>? followers, ICollection<TimeEntrie>? timeEntries, ICollection<string>? taskList)
    {
        public int Id { get; set; } = id;
        public required string Name { get; set; } = name;
        public required string Number { get; set; } = number;
        public string? Description { get; set; } = description;

        public required BillingType BillingType { get; set; } = billingType;
        public bool Completed { get; set; } = completed;
        public bool Invoced { get; set; } = invoced;
        public DateTime? DueDate { get; set; } = dueDate;
        public DateTime? EndDate { get; set; } = endDate;
        public DateTime? StartDate { get; set; } = startDate;
        public decimal? EstimateBillableAmount { get; set; } = estimateBillableAmount;
        public decimal? EstimateCost { get; set; } = estimateCost;
        public decimal? HourlyRate { get; set; } = hourlyRate;
        public double? EstimateHours { get; set; } = estimateHours;
        public double? HoursLeft { get; set; } = hoursLeft;
        public double? HoursWorked { get; set; } = hoursWorked;
        public double? ProgressStatus { get; set; } = progressStatus;
        public double? WorkedFromTotal { get; set; } = workedFromTotal;
        public string? Priority { get; set; } = priority;
        public CreateBase? Create { get; set; } = create;
        public int? ProjectId { get; private set; } = projectId;
        public Project? Project { get; private set; } = project;

        public ICollection<People>? AssignedTo { get; set; } = assignedTo;
        public ICollection<People>? Followers { get; set; } = followers;
        public ICollection<TimeEntrie>? TimeEntries { get; set; } = timeEntries;
        public ICollection<string>? TaskList { get; set; } = taskList;
    }
}
