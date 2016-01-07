using GreenTeam.Data.Entities;
using System.Collections.Generic;

namespace GreenTeam.Data.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetPersonList();
        Person GetPerson(string urlName);
    }
}
