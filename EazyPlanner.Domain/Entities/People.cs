using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{

    public class People(int id, string name, DateTime? birthDate, string? genre, CreateBase? create, int? customerSupplierId, CustomerSupplier? customerSupplier)
    {
        public int Id { get; private set; } = id;
        public required string Name { get; set; } = name;
        public DateTime? BirthDate { get; set; } = birthDate;
        public string? Genre { get; set; } = genre;
        public CreateBase? Create { get; set; } = create;

        public int? CustomerSupplierId { get; private set; } = customerSupplierId;
        public CustomerSupplier? CustomerSupplier { get; private set; } = customerSupplier;
    }
}