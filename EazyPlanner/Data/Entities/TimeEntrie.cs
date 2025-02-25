using EazyPlanner.Data.Bases;
using EazyPlanner.Data.Enums;

namespace EazyPlanner.Data.Entities
{
    public class TimeEntrie(int id, TimeEntryType timeEntry, DateTime date)
    {
        public int Id { get; set; } = id;
        public TimeEntryType TimeEntry { get; set; } = timeEntry;
        public DateTime Date { get; set; } = date;
        public DateTime? EndDate { get; set; } = DateTime.UtcNow;
        public DateTime? StartDate { get; set; } = DateTime.UtcNow;
        public double? Duration { get; set; } = 0;
        public string? Note { get; set; } = string.Empty;

        public CreateBase? Create { get; set; } = new();

        public int? ChoreId { get; set; } = 0;
        public Chore? Chore { get; set; } = new(0, string.Empty, string.Empty);

        public int? UserId { get; set; }
        public PersonAccount? User { get; set; }
    }
}
