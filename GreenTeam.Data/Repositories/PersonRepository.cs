using System.Collections.Generic;
using System.Linq;
using GreenTeam.Data.Entities;

namespace GreenTeam.Data.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PersonRepository(IContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the person list.
        /// </summary>
        /// <returns>The person list</returns>
        public List<Person> GetPersonList()
        {
            return _context.Persons;
        }

        /// <summary>
        /// Gets the person by urlName
        /// </summary>
        /// <param name="urlName">Name of the URL.</param>
        /// <returns>The person</returns>
        public Person GetPerson(string urlName)
        {
            return _context.Persons.FirstOrDefault(f => f.UrlName == urlName);
        }
    }
}
