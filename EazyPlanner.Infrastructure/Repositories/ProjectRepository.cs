using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Repositories
{
    class ProjectRepository(ApplicationDbContext context) : IProjectRepository
    {
        private ApplicationDbContext _context = context;

        public async Task<Project> AddProject(Project project)
        {
            if (_context is not null && project is not null && _context.Project is not null)
            {

                _context.Project.Add(project);
                await _context.SaveChangesAsync();
                return project;

            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task DeleteProject(int id)
        {
            var project = await GetProjectById(id);
            if (project is not null)
            {
                _context.Project.Remove(project);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Invalid data...");
            }
        }

        public async Task<Project?> GetProjectById(int id)
        {

            var project = await _context.Project.FirstOrDefaultAsync(c => c.Id == id);
            if (project is null)
            {
                throw new InvalidOperationException($"Project with id{id} was not found.");
            }
            return project;
        }

        public async Task<bool> ProjectNumberExists(string number)
        {
            return await _context.Project.AnyAsync(c => c.Number == number);
        }


        public async Task<IEnumerable<Project>> GetProjects()
        {
            if (_context is not null && _context.Project is not null)
            {
                var project = await _context.Project.ToListAsync();
                return project;
            }
            else
            {
                return new List<Project>();
            }
        }

        public async Task UpdateProject(Project project)
        {
            if (project is not null)
            {
                _context.Entry(project).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Invalid data...");
            }
        }
    }
}
