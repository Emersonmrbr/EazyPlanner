using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IFinanceRecordRepository
    {
        IEnumerable<FinancialRecord> GetFinancialRecords();
        Task<FinancialRecord?> GetFinancialRecord(int id);
        Task<FinancialRecord> AddFinancialRecord(FinancialRecord financialRecord);
        Task<FinancialRecord> UpdateFinancialRecord(FinancialRecord financialRecord);
        Task<FinancialRecord> DeleteFinancialRecord(int id);
    }
}
