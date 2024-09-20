using EazyPlanner.Domain.Entities;
namespace EazyPlanner.Domain.Abstractions
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects();
        Task<Project?> GetProjectById(int id);
        Task<bool> ProjectNumberExists(string number);
        Task<Project> AddProject(Project project);
        Task UpdateProject(Project prpject);
        Task DeleteProject(int id);
    }
}
