using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{

    public class People(int peopleId,
                  string name,
                  DateTime birthDate,
                  string? genre)
    {
        public int PeopleId { get; private set; } = peopleId;
        public required string Name { get; set; } = name;
        public DateTime BirthDate { get; set; } = birthDate;
        public string? Genre { get; set; } = genre;
        public CreateBase? Create { get; set; }

        public int? CustomerSupplierId { get; set; }
        public CustomerSupplier? CustomerSupplier { get; set; }
    }
}