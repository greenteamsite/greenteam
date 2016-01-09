using GreenTeam.Data.Entities;
using GreenTeam.Data.Models;
using GreenTeam.Data.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace GreenTeam.Web.Controllers
{
    public class ProjectController : ApiController
    {
        private IProjectRepository _projectRepo;

        public ProjectController(IProjectRepository projectRepo)
        {
            _projectRepo = projectRepo;
        }

        public List<Project> GetProjects()
        {
            var model = _projectRepo.GetProjectList();
            return model;
        }

        public List<ProjectRole> GetProjectsByPerson(string urlName)
        {
            var model = _projectRepo.GetProjectsByPerson(urlName);
            return model;
        }
    }
}
