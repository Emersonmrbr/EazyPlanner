using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
  public interface IPeopleRepository
  {
    Task<IEnumerable<People>> GetPeoples();
    Task<People?> GetPeople(int id);
    Task<People> AddPeople(People people);
    Task UpdatePeople(People people);
    Task DeletePeople(int id);
  }
}
