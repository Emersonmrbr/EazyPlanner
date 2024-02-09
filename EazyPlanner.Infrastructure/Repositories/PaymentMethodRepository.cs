using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyPlanner.Infrastructure.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private ApplicationDbContext _context;

        public PaymentMethodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaymentMethod> AddPaymentMethod(PaymentMethod paymentMethod)
        {
            if (_context is not null && paymentMethod is not null && _context.PaymentMethod is not null)
            {
                _context.PaymentMethod.Add(paymentMethod);
                await _context.SaveChangesAsync();
                return paymentMethod;
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeletePaymentMethod(int id)
        {
            var paymentMethod = await GetPaymentMethod(id);
            if (paymentMethod is not null)
            {
                _context.PaymentMethod.Remove(paymentMethod);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<PaymentMethod?> GetPaymentMethod(int id)
        {
            var paymentMethod = await _context.PaymentMethod.FirstOrDefaultAsync(c => c.PaymentMethodId == id);
            if (paymentMethod is null)
            {
                throw new InvalidOperationException($"Payment method with id{id} not found");
            }
            return paymentMethod;
        }

        public async Task<IEnumerable<PaymentMethod>> GetPaymentMethods()
        {
            if (_context is not null && _context.PaymentMethod is not null)
            {
                var paymentMethod = await _context.PaymentMethod.ToListAsync();
                return paymentMethod;
            }
            else
            {
                return new List<PaymentMethod>();
            }
        }

        public async Task UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            if (paymentMethod is not null)
            {
                _context.Entry(paymentMethod).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
