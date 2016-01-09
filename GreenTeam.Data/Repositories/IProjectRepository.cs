using GreenTeam.Data.Entities;
using GreenTeam.Data.Models;
using System.Collections.Generic;

namespace GreenTeam.Data.Repositories
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <returns>The projects</returns>
        List<Project> GetProjectList();

        /// <summary>
        /// Gets the projects by person
        /// </summary>
        /// <param name="urlName">Name of the URL.</param>
        /// <returns>List of ProjectRole</returns>
        List<ProjectRole> GetProjectsByPerson(string urlName);
    }
}
