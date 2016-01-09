using GreenTeam.Data.Entities;
using GreenTeam.Data.Repositories;
using GreenTeam.Web.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace GreenTeam.Web.Controllers
{
    public class AboutController : ApiController
    {
        private IPersonRepository _personRepo;

        public AboutController(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public AboutVm GetAboutInfo()
        {
            var model = new AboutVm
            {
                Persons = _personRepo.GetPersonList()
            };

            return model;
        }
    }
}
