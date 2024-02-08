using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IcostCenterRepository
    {
        IEnumerable<CostCenter> GetCostCenters();
        Task<CostCenter?> GetCostCenter(int id);
        Task<CostCenter> AddCostCenter(CostCenter costCenter);
        Task<CostCenter> UpdateCostCenter(CostCenter costCenter);
        Task<CostCenter> DeleteCostCenter(int id);
    }
}
