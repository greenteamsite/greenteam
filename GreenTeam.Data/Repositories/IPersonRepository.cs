using GreenTeam.Data.Entities;
using System.Collections.Generic;

namespace GreenTeam.Data.Repositories
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Gets the person list.
        /// </summary>
        /// <returns>The person list</returns>
        List<Person> GetPersonList();

        /// <summary>
        /// Gets the person by urlName
        /// </summary>
        /// <param name="urlName">Name of the URL.</param>
        /// <returns>The person</returns>
        Person GetPerson(string urlName);
    }
}
