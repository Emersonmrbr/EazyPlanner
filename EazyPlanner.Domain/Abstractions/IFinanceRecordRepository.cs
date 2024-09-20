using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IFinanceRecordRepository
    {
        Task<IEnumerable<FinancialRecord>> GetFinancialRecords();
        Task<FinancialRecord?> GetFinancialRecordById(int id);
        Task<FinancialRecord> AddFinancialRecord(FinancialRecord financialRecord);
        Task UpdateFinancialRecord(FinancialRecord financialRecord);
        Task DeleteFinancialRecord(int id);
    }
}
