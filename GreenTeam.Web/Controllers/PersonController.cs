using GreenTeam.Data.Entities;
using GreenTeam.Data.Repositories;
using System.Web.Http;

namespace GreenTeam.Web.Controllers
{
    public class PersonController : ApiController
    {
        private IPersonRepository _personRepo;

        public PersonController(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public Person GetPerson(string urlName)
        {
            var model = _personRepo.GetPerson(urlName);
            return model;
        }
    }
}
