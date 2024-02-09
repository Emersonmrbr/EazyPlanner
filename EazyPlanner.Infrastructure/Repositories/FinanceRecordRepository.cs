using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class FinanceRecordRepository : IFinanceRecordRepository
    {
        private ApplicationDbContext _context;

        public FinanceRecordRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<FinancialRecord> AddFinancialRecord(FinancialRecord financialRecord)
        {
            if (_context is not null && financialRecord is not null && _context.FinancialRecord is not null)
            {
                _context.FinancialRecord.Add(financialRecord);
                await _context.SaveChangesAsync();
                return financialRecord;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteFinancialRecord(int id)
        {
            var financialRecord = await GetFinancialRecord(id);
            if (financialRecord is not null)
            {
                _context.FinancialRecord.Remove(financialRecord);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<FinancialRecord?> GetFinancialRecord(int id)
        {
            var financialRecord = await _context.FinancialRecord.FirstOrDefaultAsync(c => c.FinancialRecordId == id);
            if (financialRecord is null)
            {
                throw new InvalidOperationException($"Financial record method with id{id} not found");
            }
            return financialRecord;
        }

        public async Task<IEnumerable<FinancialRecord>> GetFinancialRecords()
        {
            if (_context is not null && _context.FinancialRecord is not null)
            {
                var financialRecords = await _context.FinancialRecord.ToListAsync();
                return financialRecords;
            }
            else
            {
                return new List<FinancialRecord>();
            }
        }

        public async Task UpdateFinancialRecord(FinancialRecord financialRecord)
        {
            if (financialRecord is not null)
            {
                _context.Entry(financialRecord).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
