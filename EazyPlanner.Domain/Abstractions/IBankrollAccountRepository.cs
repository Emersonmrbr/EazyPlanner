using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
  public interface IBankrollAccountRepository
  {
    Task<IEnumerable<BankrollAccount>> GetBankrollAccounters();
    Task<BankrollAccount?> GetBankrollAccount(int id);
    Task<BankrollAccount> AddBankrollAccount(BankrollAccount bankrollAccount);
    Task UpdateBankrollAccount(BankrollAccount bankrollAccount);
    Task DeleteBankrollAccount(int id);
  }
}
