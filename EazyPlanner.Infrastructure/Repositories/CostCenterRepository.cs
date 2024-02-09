using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class CostCenterRepository : IcostCenterRepository
    {
        private ApplicationDbContext _context;

        public CostCenterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CostCenter> AddCostCenter(CostCenter costCenter)
        {
            if (_context is not null && costCenter is not null && _context.CostCenter is not null)
            {
                _context.CostCenter.Add(costCenter);
                await _context.SaveChangesAsync();
                return costCenter;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteCostCenter(int id)
        {
            var costCenter = await GetCostCenter(id);
            if (costCenter is not null)
            {
                _context.CostCenter.Remove(costCenter);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<CostCenter?> GetCostCenter(int id)
        {
            var costCenter = await _context.CostCenter.FirstOrDefaultAsync(c => c.CostCenterId == id);
            if (costCenter is null)
            {
                throw new InvalidOperationException($"Cost center com id{id} não encontrado");
            }
            return costCenter;
        }

        public async Task<IEnumerable<CostCenter>> GetCostCenters()
        {
            if (_context is not null && _context.CostCenter is not null)
            {
                var costCenters = await _context.CostCenter.ToListAsync();
                return costCenters;
            }
            else
            {
                return new List<CostCenter>();
            }
        }

        public async Task UpdateCostCenter(CostCenter costCenter)
        {
            if (costCenter is not null)
            {
                _context.Entry(costCenter).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
