using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IFinanceCategoryRepository
    {
        IEnumerable<FinanceCategory> GetFinanceCategory();
        Task<FinanceCategory?> GetFinanceCategory(int id);
        Task<FinanceCategory> AddFinanceCategory(FinanceCategory financeCategory);
        Task<FinanceCategory> UpdateFinanceCategory(FinanceCategory financeCategory);
        Task<FinanceCategory> DeleteFinanceCategory(int id);
    }
}
