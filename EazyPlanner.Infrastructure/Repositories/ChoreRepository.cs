using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class ChoreRepository(ApplicationDbContext context) : IChoreRepository
    {
        private ApplicationDbContext _context = context;

        public async Task<Chore> AddChore(Chore chore)
        {
            if (_context is not null && chore is not null && _context.Chore is not null)
            {

                _context.Chore.Add(chore);
                await _context.SaveChangesAsync();
                return chore;

            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteChore(int id)
        {
            var chore = await GetChoreById(id);
            if (chore is not null)
            {
                _context.Chore.Remove(chore);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<Chore?> GetChoreById(int id)
        {

            var chore = await _context.Chore.FirstOrDefaultAsync(c => c.Id == id);
            if (chore is null)
            {
                throw new InvalidOperationException("Chore with id{id} was not found.");
            }
            return chore;
        }

        public async Task<bool> ChoreNumberExists(string number)
        {
            return await _context.Chore.AnyAsync(c => c.Number == number);
        }


        public async Task<IEnumerable<Chore>> GetChores()
        {
            if (_context is not null && _context.Chore is not null)
            {
                var chore = await _context.Chore.ToListAsync();
                return chore;
            }
            else
            {
                return new List<Chore>();
            }
        }

        public async Task UpdateChore(Chore chore)
        {
            if (chore is not null)
            {
                _context.Entry(chore).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
