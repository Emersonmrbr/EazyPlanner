using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class CustomerSupplierRepository(ApplicationDbContext context) : ICustomerSupplierRepository
    {

        private ApplicationDbContext _context = context;

        public async Task<CustomerSupplier> AddCustomerSupplier(CustomerSupplier customerSupplier)
        {
            if (_context is not null && customerSupplier is not null && _context.CustomerSupplier is not null)
            {

                _context.CustomerSupplier.Add(customerSupplier);
                await _context.SaveChangesAsync();
                return customerSupplier;

            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteCustomerSupplier(int id)
        {
            var customerSupplier = await GetCustomerSupplierById(id);
            if (customerSupplier is not null)
            {
                _context.CustomerSupplier.Remove(customerSupplier);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<CustomerSupplier?> GetCustomerSupplierById(int id)
        {

            var customerSupplier = await _context.CustomerSupplier.FirstOrDefaultAsync(c => c.Id == id);
            if (customerSupplier is null)
            {
                throw new InvalidOperationException($"Costumer supplier with id{id} was not found.");
            }
            return customerSupplier;
        }

        public async Task<bool> CnpjExists(string cnpj)
        {
            return await _context.CustomerSupplier.AnyAsync(c => c.CNPJ == cnpj);
        }


        public async Task<IEnumerable<CustomerSupplier>> GetCustomersSuppliers()
        {
            if (_context is not null && _context.CustomerSupplier is not null)
            {
                var customersSuppliers = await _context.CustomerSupplier.ToListAsync();
                return customersSuppliers;
            }
            else
            {
                return new List<CustomerSupplier>();
            }
        }

        public async Task UpdateCustomerSupplier(CustomerSupplier customerSupplier)
        {
            if (customerSupplier is not null)
            {
                _context.Entry(customerSupplier).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
