using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
  public interface ICustomerSupplierRepository
  {
    Task<IEnumerable<CustomerSupplier>> GetCustomersSuppliers();
    Task<CustomerSupplier?> GetCustomerSupplier(int id);
    Task<CustomerSupplier> AddCustomerSupplier(CustomerSupplier customerSupplier);
    Task UpdateCustomerSupplier(CustomerSupplier customerSupplier);
    Task DeleteCustomerSupplier(int id);
  }
}
