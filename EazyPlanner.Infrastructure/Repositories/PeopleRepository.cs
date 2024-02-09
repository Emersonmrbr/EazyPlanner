using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private ApplicationDbContext _context;
        public PeopleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<People> AddPeople(People people)
        {
            if (_context is not null && people is not null && _context.People is not null)
            {
                _context.People.Add(people);
                await _context.SaveChangesAsync();
                return people;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeletePeople(int id)
        {
            var people = await GetPeople(id);
            if (people is not null)
            {
                _context.People.Remove(people);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<People?> GetPeople(int id)
        {
            var people = await _context.People.FirstOrDefaultAsync(c => c.PeopleId == id);
            if (people is null)
            {
                throw new InvalidOperationException($"People method with id{id} not found");
            }
            return people;
        }

        public async Task<IEnumerable<People>> GetPeoples()
        {
            if (_context is not null && _context.People is not null)
            {
                var people = await _context.People.ToListAsync();
                return people;
            }
            else
            {
                return new List<People>();
            }
        }

        public async Task UpdatePeople(People people)
        {
            if (people is not null)
            {
                _context.Entry(people).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
