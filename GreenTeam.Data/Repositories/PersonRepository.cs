using System.Collections.Generic;
using System.Linq;
using GreenTeam.Data.Entities;

namespace GreenTeam.Data.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IContext _context;

        public PersonRepository(IContext context)
        {
            _context = context;
        }

        public List<Person> GetPersonList()
        {
            return _context.Persons;
        }

        public Person GetPerson(string urlName)
        {
            return _context.Persons.FirstOrDefault(f => f.UrlName == urlName);
        }
    }
}
