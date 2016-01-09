using GreenTeam.Data;
using GreenTeam.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GreenTeam.Test
{
    [TestClass]
    public class ProjectRepositoryTest
    {
        private readonly IContext _context;
        private readonly ProjectRepository _projectRepo;

        public ProjectRepositoryTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\database.json";
            _context = new JsonContext(path);
            _projectRepo = new ProjectRepository(_context);
        }

        [TestMethod]
        public void GetProjectListIsNotNull()
        {
            Assert.IsNotNull(_projectRepo.GetProjectList());
        }

        [TestMethod]
        public void GetPersonListIsNotEmptyData()
        {
            Assert.IsTrue(_projectRepo.GetProjectList().Count > 0);
        }

        [TestMethod]
        public void GetProjectsByPersonIsNotNull()
        {
            Assert.IsNotNull(_projectRepo.GetProjectsByPerson("alex-green"));
        }

        [TestMethod]
        public void GetProjectsByPersonIsEmpty()
        {
            Assert.IsTrue(_projectRepo.GetProjectsByPerson("noName").Count == 0);
        }

        [TestMethod]
        public void GetProjectsByPersonIsEmptyPassNullParam()
        {
            Assert.IsTrue(_projectRepo.GetProjectsByPerson(null).Count == 0);
        }
    }
}
