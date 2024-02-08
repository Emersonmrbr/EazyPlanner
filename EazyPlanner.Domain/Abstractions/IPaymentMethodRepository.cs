using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IPaymentMethodRepository
    {
        IEnumerable<PaymentMethod> GetPaymentMethods();
        Task<PaymentMethod?> GetPaymentMethod(int id);
        Task<PaymentMethod> AddPaymentMethod(PaymentMethod paymentMethod);
        Task<PaymentMethod> UpdatePaymentMethod(PaymentMethod paymentMethod);
        Task<PaymentMethod> DeletePaymentMethod(int id);
    }
}
