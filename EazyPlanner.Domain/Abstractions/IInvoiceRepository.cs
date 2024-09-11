using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IInvoiceRepository
    {
        Task<IEnumerable<Invoice>> GetInvoices();
        Task<Invoice?> GetInvoice(int id);
        Task<Invoice> AddInvoice(Invoice invoice);
        Task UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
    }
}
