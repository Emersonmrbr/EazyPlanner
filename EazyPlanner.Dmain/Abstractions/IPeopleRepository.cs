using EazyPlanner.Domain.Entities;

namespace EazyPlanner.Domain.Abstractions
{
    public interface IPeopleRepository
    {
        IEnumerable<People> GetPeoples();
        Task<People?> GetPeople(int id);
        Task<People> AddPeople(People people);
        Task<People> UpdatePeople(People people);
        Task<People> DeletePeople(int id);
    }
}
