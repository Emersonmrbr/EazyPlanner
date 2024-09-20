using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IFinanceCategoryRepository
    {
        Task<IEnumerable<FinanceCategory>> GetFinanceCategories();
        Task<FinanceCategory?> GetFinanceCategoryById(int id);
        Task<FinanceCategory> AddFinanceCategory(FinanceCategory financeCategory);
        Task UpdateFinanceCategory(FinanceCategory financeCategory);
        Task DeleteFinanceCategory(int id);
    }
}
