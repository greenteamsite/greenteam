using GreenTeam.Data;
using GreenTeam.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GreenTeam.Test
{
    [TestClass]
    public class PersonRepositoryTest
    {
        private readonly IContext _context;
        private readonly PersonRepository _personRepo;

        public PersonRepositoryTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\database.json";
            _context = new JsonContext(path);
            _personRepo = new PersonRepository(_context);
        }

        [TestMethod]
        public void GetPersonListIsNotNull()
        {
            Assert.IsNotNull(_personRepo.GetPersonList());
        }

        [TestMethod]
        public void GetPersonListIsNotEmptyData()
        {
            Assert.IsTrue(_personRepo.GetPersonList().Count > 0);
        }

        [TestMethod]
        public void GetPersonIsNotNull()
        {
            Assert.IsNotNull(_personRepo.GetPerson("alex-green"));
        }

        [TestMethod]
        public void GetPersonIsNull()
        {
            Assert.IsNull(_personRepo.GetPerson("noName"));
        }

        [TestMethod]
        public void GetPersonIsNullPassNullParam()
        {
            Assert.IsNull(_personRepo.GetPerson(null));
        }
    }
}
