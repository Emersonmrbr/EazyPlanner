using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetInvoices();
        Task<Invoice?> GetInvoice(int id);
        Task<Invoice> AddInvoice(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<Invoice> DeleteInvoice(int id);
    }
}
