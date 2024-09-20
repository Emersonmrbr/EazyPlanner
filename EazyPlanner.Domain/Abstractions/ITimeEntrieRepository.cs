using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface ITimeEntrieRepository
    {
        Task<IEnumerable<TimeEntrie>> GetTimeEntries();
        Task<TimeEntrie?> GetTimeEntrieById(int id);
        Task<TimeEntrie> AddTimeEntrie(TimeEntrie timeEntrie);
        Task UpdateTimeEntrie(TimeEntrie timeEntrie);
        Task DeleteTimeEntrie(int id);
    }
}
