using GreenTeam.Data.Entities;
using GreenTeam.Data.Models;
using System.Collections.Generic;

namespace GreenTeam.Data.Repositories
{
    public interface IProjectRepository
    {
        List<Project> GetProjects();
        Project GetProject(int id);
        List<ProjectRole> GetProjectsByPerson(string urlName);
    }
}
