using System.Collections.Generic;
using System.Linq;
using GreenTeam.Data.Entities;
using GreenTeam.Data.Models;

namespace GreenTeam.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IContext _context;

        public ProjectRepository(IContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <returns>The projects</returns>
        public List<Project> GetProjectList()
        {
            return _context.Projects;
        }

        /// <summary>
        /// Gets the projects by person
        /// </summary>
        /// <param name="urlName">Name of the URL.</param>
        /// <returns>List of ProjectRole</returns>
        public List<ProjectRole> GetProjectsByPerson(string urlName)
        {
            var projectRoles = from personPr in _context.PersonProjects.Where(w => w.PersonUrlName == urlName).Select(s => new { s.ProjectId, s.PersonRole })
                               join project in _context.Projects on personPr.ProjectId equals project.Id
                               select new ProjectRole
                               {
                                   Project = project,
                                   PersonRole = personPr.PersonRole
                               };
            return projectRoles.ToList();
        }
    }
}
