using EazyPlanner.Domain.Entities;
namespace EazyPlanner.Domain.Abstractions
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects();
        Task<Project?> GetProject(int id);
        Task<Project> AddProject(Project project);
        Task UpdateProject(Project prpject);
        Task DeleteProject(int id);
    }
}
