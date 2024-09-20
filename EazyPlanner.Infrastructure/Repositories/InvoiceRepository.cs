using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class InvoiceRepository(ApplicationDbContext context) : IInvoiceRepository
    {

        private ApplicationDbContext _context = context;

        public async Task<Invoice> AddInvoice(Invoice invoice)
        {
            if (_context is not null && invoice is not null && _context.Invoice is not null)
            {
                _context.Invoice.Add(invoice);
                await _context.SaveChangesAsync();
                return invoice;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteInvoice(int id)
        {
            var invoice = await GetInvoiceById(id);
            if (invoice is not null)
            {
                _context.Invoice.Remove(invoice);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<Invoice?> GetInvoiceById(int id)
        {
            var invoice = await _context.Invoice.FirstOrDefaultAsync(c => c.Id == id);
            if (invoice is null)
            {
                throw new InvalidOperationException($"Invoice with id{id} was not found.");
            }
            return invoice;
        }

        public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            if (_context is not null && _context.Invoice is not null)
            {
                var invoice = await _context.Invoice.ToListAsync();
                return invoice;
            }
            else
            {
                return new List<Invoice>();
            }
        }

        public async Task UpdateInvoice(Invoice invoice)
        {
            if (invoice is not null)
            {
                _context.Entry(invoice).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
