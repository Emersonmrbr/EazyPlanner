using EazyPlanner.Domain.Entities;
namespace EazyPlanner.Domain.Abstractions
{
    public interface IChoreRepository
    {
        Task<IEnumerable<Chore>> GetChores();
        Task<Chore?> GetChoreById(int id);
        Task<bool> ChoreNumberExists(string number);
        Task<Chore> AddChore(Chore chore);
        Task UpdateChore(Chore chore);
        Task DeleteChore(int id);
    }
}
