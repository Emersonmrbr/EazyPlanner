using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IcostCenterRepository
    {
        Task<IEnumerable<CostCenter>> GetCostCenters();
        Task<CostCenter?> GetCostCenterById(int id);
        Task<CostCenter> AddCostCenter(CostCenter costCenter);
        Task UpdateCostCenter(CostCenter costCenter);
        Task DeleteCostCenter(int id);
    }
}
