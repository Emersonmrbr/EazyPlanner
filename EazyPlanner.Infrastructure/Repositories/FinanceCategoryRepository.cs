using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class FinanceCategoryRepository(ApplicationDbContext context) : IFinanceCategoryRepository
    {
        private ApplicationDbContext _context = context;

        public async Task<FinanceCategory> AddFinanceCategory(FinanceCategory financeCategory)
        {
            if (_context is not null && financeCategory is not null && _context.FinanceCategory is not null)
            {
                _context.FinanceCategory.Add(financeCategory);
                await _context.SaveChangesAsync();
                return financeCategory;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteFinanceCategory(int id)
        {
            var financeCategory = await GetFinanceCategoryById(id);
            if (financeCategory is not null)
            {
                _context.FinanceCategory.Remove(financeCategory);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<FinanceCategory?> GetFinanceCategoryById(int id)
        {
            var financeCategory = await _context.FinanceCategory.FirstOrDefaultAsync(c => c.Id == id);
            if (financeCategory is null)
            {
                throw new InvalidOperationException($"Finance category method with id{id} was not found.");
            }
            return financeCategory;
        }

        public async Task<IEnumerable<FinanceCategory>> GetFinanceCategories()
        {
            if (_context is not null && _context.FinanceCategory is not null)
            {
                var financeCategories = await _context.FinanceCategory.ToListAsync();
                return financeCategories;
            }
            else
            {
                return new List<FinanceCategory>();
            }
        }

        public Task UpdateFinanceCategory(FinanceCategory financeCategory)
        {
            throw new NotImplementedException();
        }
    }
}
