using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IBankrollAccountRepository
    {
        IEnumerable<BankrollAccount> GetCustomers();
        Task<BankrollAccount?> GetCustomer(int id);
        Task<BankrollAccount> AddCustomer(BankrollAccount bankrollAccount);
        Task<BankrollAccount> UpdateCustomer(BankrollAccount bankrollAccount);
        Task<BankrollAccount> DeleteCustomer(int id);
    }
}
