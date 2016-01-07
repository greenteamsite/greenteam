using GreenTeam.Data.Repositories;
using GreenTeam.Web.Models;
using System;
using System.Web.Http;

namespace GreenTeam.Web.Controllers
{
    public class HomeController : ApiController
    {
        private IPersonRepository _personRepo;

        public HomeController(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public HomeVm GetHomeInfo()
        {
            var model = new HomeVm {
                Title = "GetHomeInfo",
                Persons = _personRepo.GetPersonList()
            };
            return model;
        }

    }
}
