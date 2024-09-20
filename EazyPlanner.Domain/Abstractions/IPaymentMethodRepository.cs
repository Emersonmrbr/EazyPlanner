using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IPaymentMethodRepository
    {
        Task<IEnumerable<PaymentMethod>> GetPaymentMethods();
        Task<PaymentMethod?> GetPaymentMethodById(int id);
        Task<PaymentMethod> AddPaymentMethod(PaymentMethod paymentMethod);
        Task UpdatePaymentMethod(PaymentMethod paymentMethod);
        Task DeletePaymentMethod(int id);
    }
}
