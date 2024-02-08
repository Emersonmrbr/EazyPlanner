using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface ICustomerSupplierRepository
    {
        IEnumerable<CustomerSupplier> GetCustomersSuppliers();
        Task<CustomerSupplier?> GetCustomerSupplier(int id);
        Task<CustomerSupplier> AddCustomerSupplier(CustomerSupplier customerSupplier);
        Task<CustomerSupplier> UpdateCustomerSupplier(CustomerSupplier customerSupplier);
        Task<CustomerSupplier> DeleteCustomerSupplier(int id);
    }
}
