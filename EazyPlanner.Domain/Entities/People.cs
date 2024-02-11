using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{

    public class People
    {
        public People(int peopleId,
                      string name,
                      DateTime birthDate,
                      string? genre,
                      CreateBase? create)
        {
            PeopleId = peopleId;
            Name = name;
            BirthDate = birthDate;
            Genre = genre;
            Create = create;
        }

        public int PeopleId { get; private set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Genre { get; set; }
        public CreateBase? Create { get; set; }
        public int? CustomerSupplierId { get; set; }

        public List<CustomerSupplier>? CustomerSuppliers { get; set; }
    }
}