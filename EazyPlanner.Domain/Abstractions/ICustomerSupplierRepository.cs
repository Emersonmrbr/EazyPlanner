using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface ICustomerSupplierRepository
    {
        Task<IEnumerable<CustomerSupplier>> GetCustomersSuppliers();
        Task<CustomerSupplier?> GetCustomerSupplierById(int id);
        Task<bool> CnpjExists(string cnpj);
        Task<CustomerSupplier> AddCustomerSupplier(CustomerSupplier customerSupplier);
        Task UpdateCustomerSupplier(CustomerSupplier customerSupplier);
        Task DeleteCustomerSupplier(int id);
    }
}
