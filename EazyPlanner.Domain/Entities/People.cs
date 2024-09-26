using EazyPlanner.Domain.Bases;

namespace EazyPlanner.Domain.Entities
{

    public class People(int id, string name, DateTime? birth, string? genre)
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public DateTime? Birth { get; set; } = birth;
        public string? Genre { get; set; } = genre;
        public CreateBase? Create { get; set; } = new();

        public int? CustomerSupplierId { get; private set; } = 0;
        public CustomerSupplier? CustomerSupplier { get; private set; } = new(0, string.Empty, string.Empty);
        public int? ChoreId { get; set; } = 0;
        public Chore? Chore { get; set; } = new(0, string.Empty, string.Empty);
        public int? ProjectId { get; set; } = 0;
        public Project? Project { get; set; } = new(0, string.Empty, string.Empty);
        public ICollection<TimeEntrie> TimeEntries { get; set; } = [];

    }
}