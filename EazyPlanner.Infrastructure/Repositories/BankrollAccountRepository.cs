using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class BankrollAccountRepository(ApplicationDbContext context) : IBankrollAccountRepository
    {
        private ApplicationDbContext _context = context;

        public async Task<BankrollAccount> AddBankrollAccount(BankrollAccount bankrollAccount)
        {
            if (_context is not null && bankrollAccount is not null && _context.BankrollAccount is not null)
            {
                _context.BankrollAccount.Add(bankrollAccount);
                await _context.SaveChangesAsync();
                return bankrollAccount;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteBankrollAccount(int id)
        {
            var bankrollAccount = await GetBankrollAccountById(id);
            if (bankrollAccount is not null)
            {
                _context.BankrollAccount.Remove(bankrollAccount);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }


        public async Task<BankrollAccount?> GetBankrollAccountById(int id)
        {

            var bankrollAccount = await _context.BankrollAccount.FirstOrDefaultAsync(c => c.Id == id);
            if (bankrollAccount is null)
            {
                throw new InvalidOperationException($"Bankroll account with id{id} was not found.");
            }
            return bankrollAccount;
        }

        public async Task<IEnumerable<BankrollAccount>> GetBankrollAccounters()
        {
            if (_context is not null && _context.BankrollAccount is not null)
            {
                var BankrollAccounts = await _context.BankrollAccount.ToListAsync();
                return BankrollAccounts;
            }
            else
            {
                return new List<BankrollAccount>();
            }
        }

        public async Task UpdateBankrollAccount(BankrollAccount bankrollAccount)
        {
            if (bankrollAccount is not null)
            {
                _context.Entry(bankrollAccount).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }

    }
}
