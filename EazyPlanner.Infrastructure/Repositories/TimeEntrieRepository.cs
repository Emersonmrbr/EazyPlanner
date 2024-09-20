using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class TimeEntrieRepository(ApplicationDbContext context) : ITimeEntrieRepository
    {
        private ApplicationDbContext _context = context;
        public async Task<TimeEntrie> AddTimeEntrie(TimeEntrie timeEntrie)
        {
            if (_context is not null && timeEntrie is not null && _context.TimeEntrie is not null)
            {

                _context.TimeEntrie.Add(timeEntrie);
                await _context.SaveChangesAsync();
                return timeEntrie;

            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteTimeEntrie(int id)
        {
            var timeEntrie = await GetTimeEntrieById(id);
            if (timeEntrie is not null)
            {
                _context.TimeEntrie.Remove(timeEntrie);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }


        public async Task<TimeEntrie?> GetTimeEntrieById(int id)
        {
            var timeEntrie = await _context.TimeEntrie.FirstOrDefaultAsync(c => c.Id == id);
            if (timeEntrie is null)
            {
                throw new InvalidOperationException($"Time entrie with id{id} was not found.");
            }
            return timeEntrie;
        }

        public async Task<IEnumerable<TimeEntrie>> GetTimeEntries()
        {
            if (_context is not null && _context.TimeEntrie is not null)
            {
                var timeEntrie = await _context.TimeEntrie.ToListAsync();
                return timeEntrie;
            }
            else
            {
                return new List<TimeEntrie>();
            }
        }

        public async Task UpdateTimeEntrie(TimeEntrie timeEntrie)
        {
            if (timeEntrie is not null)
            {
                _context.Entry(timeEntrie).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}

