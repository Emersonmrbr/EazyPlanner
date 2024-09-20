using EazyPlanner.Domain.Bases;
using EazyPlanner.Domain.Enums;
namespace EazyPlanner.Domain.Entities
{
    public class TimeEntrie(int id, TimeEntryType timeEntry, DateTime? date, DateTime? endDate, DateTime? startDate, double? duration, string? note)
    {
        public int Id { get; set; } = id;
        public TimeEntryType TimeEntry { get; set; } = timeEntry;
        public DateTime? Date { get; set; } = date;
        public DateTime? EndDate { get; set; } = endDate;
        public DateTime? StartDate { get; set; } = startDate;
        public double? Duration { get; set; } = duration;
        public string? Note { get; set; } = note;

        public CreateBase? Create { get; set; } = new();

        public int? TaskId { get; private set; } = 0;
        public Chore? ProjectTask { get; private set; } = new(0, string.Empty, string.Empty);

        public ICollection<People>? User { get; set; } = [];
    }
}
