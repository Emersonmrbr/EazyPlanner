using EazyPlanner.Domain.Base;
using EazyPlanner.Domain.Enums;
namespace EazyPlanner.Domain.Entities
{
    public class TimeEntrie(int timeEntrieId, TimeEntryType timeEntry, DateTime? date, DateTime? endDate, DateTime? startDate, double? duration, string? note, CreateBase? create, int taskId, Chore task, ICollection<People>? user)
    {
        public int TimeEntrieId { get; set; } = timeEntrieId;
        public TimeEntryType TimeEntry { get; set; } = timeEntry;
        public DateTime? Date { get; set; } = date;
        public DateTime? EndDate { get; set; } = endDate;
        public DateTime? StartDate { get; set; } = startDate;
        public double? Duration { get; set; } = duration;
        public string? Note { get; set; } = note;

        public CreateBase? Create { get; set; } = create;

        public int TaskId { get; private set; } = taskId;
        public Chore ProjectTask { get; private set; } = task;

        public ICollection<People>? User { get; set; } = user;
    }
}
