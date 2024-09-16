using EazyPlanner.Domain.Entities;
namespace EazyPlanner.Domain.Abstractions
{
    public interface IChoreRepository
    {
        Task<IEnumerable<Chore>> GetChores();
        Task<Chore?> GetChore(int id);
        Task<Chore> AddChore(Chore chore);
        Task UpdateChore(Chore chore);
        Task DeleteChore(int id);
    }
}
