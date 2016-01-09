using GreenTeam.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace GreenTeam.Test
{
    [TestClass]
    public class JSonContextTest
    {
        private readonly IContext _context;

        public JSonContextTest()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\database.json";
            _context = new JsonContext(path);
        }

        [TestMethod]
        public void JsonContextDataIsNotNull()
        {
            Assert.IsNotNull(_context.PersonProjects, "PersonProjects is Null");
            Assert.IsNotNull(_context.Persons, "Persons is Null");
            Assert.IsNotNull(_context.Projects, "Projects is Null");
        }

        [TestMethod]
        public void JsonContextDataIsNotEmpty()
        {
            Assert.IsTrue(_context.PersonProjects.Count > 0, "PersonProjects count == 0");
            Assert.IsTrue(_context.Persons.Count > 0, "Persons count == 0");
            Assert.IsTrue(_context.Projects.Count > 0, "Projects count == 0");
        }
    }
}
